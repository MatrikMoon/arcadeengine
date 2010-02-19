﻿#region Licence
//
//This file is part of ArcEngine.
//Copyright (C)2008-2010 Adrien Hémery ( iliak@mimicprod.net )
//
//ArcEngine is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//any later version.
//
//ArcEngine is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
//
#endregion
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml;
using ArcEngine;
using ArcEngine.Graphic;
using ArcEngine.Asset;
using OpenTK.Graphics.OpenGL;
using DungeonEye.Interfaces;

//
// List of monsters : http://members.tripod.com/~stanislavs/games/eob1mons.htm
// http://dmweb.free.fr/?q=node/1363
//
// http://wiki.themanaworld.org/index.php/User:Crush/Monster_Database
//
// http://wiki.themanaworld.org/index.php/Monster_Database
//
//
//
namespace DungeonEye
{

	/// <summary>
	/// Base interface of all monster in the game
	/// </summary>
	public class Monster : Entity, IAsset
	{

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="maze">Maze handle where the monster is</param>
		public Monster(Maze maze)
		{
            if (maze != null)
            {
                Location = new DungeonLocation(maze.Dungeon);
            }	

			ItemsInPocket = new List<string>();
			Damage = new Dice();
			HitDice = new Dice();

			DrawOffsetDuration = TimeSpan.FromSeconds(1.0f + GameBase.Random.NextDouble());
		}


		/// <summary>
		/// Initializes the monster
		/// </summary>
		/// <returns></returns>
		public bool Init()
		{
			Tileset = ResourceManager.CreateSharedAsset<TileSet>(TileSetName, TileSetName);
			Tileset.Scale = new SizeF(2.0f, 2.0f);

			if (!string.IsNullOrEmpty(ScriptName) && !string.IsNullOrEmpty(InterfaceName))
			{
				Script script = ResourceManager.CreateAsset<Script>(ScriptName);
				script.Compile();

				Interface = script.CreateInstance<IMonster>(InterfaceName);
			}

			return true;
		}


		/// <summary>
		/// Move the monster
		/// </summary>
		/// <param name="offset">Offset</param>
		/// <returns>True if moved, or false</returns>
		private bool Move(Point offset)
		{
			// Can't move
			if (!CanMove)
				return false;

			// Get informations about the destination block
			Point dst = Location.Position;
			dst.Offset(offset);


			// Check all blocking states
			bool canmove = true;

			// The team
			if (Location.Dungeon.Team.Location.Maze == Location.Maze &&
				Location.Dungeon.Team.Location.Position == dst)
				canmove = false;

			// A wall
			MazeBlock dstblock = Location.Maze.GetBlock(dst);
			if (dstblock.IsBlocking)
				canmove = false;

			// Stairs
			if (dstblock.Stair != null)
				canmove = false;

			// Monsters
			if (Location.Maze.GetMonsterCount(dst) > 0)
				canmove = false;

			// blocking door
			if (dstblock.Door != null && dstblock.Door.IsBlocking)
				canmove = false;




			if (canmove)
			{
				// Leave the current block
			    Location.Block.OnMonsterLeave(this);
				

				Location.Position.Offset(offset);
				LastMove = DateTime.Now;

				// Enter the new block
				Location.Block.OnMonsterEnter(this);
			}

			return canmove;
		}


		/// <summary>
		/// Attack the entity
		/// </summary>
		/// <param name="attack">Attack</param>
		public override void Hit(Attack attack)
		{
			if (attack == null)
				return;

			LastAttack = attack;
			if (LastAttack.IsAMiss)
				return;

			HitPoint.Current -= LastAttack.Hit;

			// Reward the team for having killed the entity
			if (IsDead && attack.Striker is Hero)
			{
				(attack.Striker as Hero).Team.AddExperience(Reward);
			}
		}



		#region Update & Draw

		/// <summary>
		/// Update the monster logic
		/// </summary>
        /// <param name="time">Elapsed game time</param>
		public virtual void Update(GameTime time)
		{
			if (Interface != null)
				Interface.OnUpdate(this);


			// Draw offset
			if (LastDrawOffset + DrawOffsetDuration < DateTime.Now)
			{
				DrawOffset = new Point(GameBase.Random.Next(-10, 10), GameBase.Random.Next(-10, 10));
				LastDrawOffset = DateTime.Now;
			}



            // Find a new target to reach
			if (TargetRange == 0)
			{
				TargetRange = Game.Random.Next(5);

				bool ok = false;
				while (!ok)
				{
					int dir = Dice.GetD20(1);
					Point vector = Location.Position;

					switch (TargetDirection)
					{
						case CardinalPoint.North:
						{
							if (dir < 10)
							{
								TargetDirection = CardinalPoint.West;
								vector.X--;
							}
							else
							{
								TargetDirection = CardinalPoint.East;
								vector.X++;
							}
						}
						break;
						case CardinalPoint.South:
						{
							if (dir < 10)
							{
								TargetDirection = CardinalPoint.East;
								vector.X++;
							}
							else
							{
								TargetDirection = CardinalPoint.West;
								vector.X--;
							}

						}
						break;
						case CardinalPoint.West:
						{
							if (dir < 10)
							{
								TargetDirection = CardinalPoint.North;
								vector.Y--;
							}
							else
							{
								TargetDirection = CardinalPoint.South;
								vector.Y++;
							}

						}
						break;
						case CardinalPoint.East:
						{
							if (dir < 10)
							{
								TargetDirection = CardinalPoint.South;
								vector.Y++;
							}
							else
							{
								TargetDirection = CardinalPoint.North;
								vector.Y--;
							}

						}
						break;
					}

					// Check the block
					MazeBlock block = Location.Maze.GetBlock(vector);
					if (block == null)
						continue;

					ok = !block.IsBlocking;
				}
			}


			// Move the monster
			if (CanMove)
			{
				// Change direction first
				if (Location.Direction != TargetDirection)
				{
					Location.Direction = TargetDirection;
					LastMove = DateTime.Now;
				}
				// Then move to the target
				else
				{
					Point vector = Point.Empty;
					switch (TargetDirection)
					{
						case CardinalPoint.North:
						vector.Y = -1;
						break;
						case CardinalPoint.South:
						vector.Y = 1;
						break;
						case CardinalPoint.West:
						vector.X = -1;
						break;
						case CardinalPoint.East:
						vector.X = 1;
						break;
					}
					TargetRange--;


					if (!Move(vector))
						TargetRange = 0;
				}
			}
		}




		/// <summary>
		/// Draw the monster
		/// </summary>
		/// <param name="direction">Team's facing direction</param>
		/// <param name="pos">Position of the monster in the field of view</param>
		public virtual void Draw(CardinalPoint direction, ViewFieldPosition pos)
		{

			TextureEnvMode mode = Display.TexEnv;

			

			// Monster was hit, redraw it
			if (LastAttack != null && LastAttack.Time + TimeSpan.FromSeconds(0.25) > DateTime.Now)
			{
				Display.BlendingFunction(BlendingFactorSrc.SrcAlpha , BlendingFactorDest.OneMinusSrcAlpha);
				Display.TexEnv = TextureEnvMode.Add;
			}


			switch (pos)
			{
				case ViewFieldPosition.B:
				Tileset.Scale = new SizeF(0.75f, 0.75f);
				Display.Color = Color.Gray;
				Tileset.Draw(GetTileID(direction), new Point(0 + DrawOffset.X / 4, 110 + DrawOffset.Y / 4));
				Tileset.Scale = new SizeF(2.0f, 2.0f);
				break;
				case ViewFieldPosition.C:
				Tileset.Scale = new SizeF(0.75f, 0.75f);
				Display.Color = Color.Gray;
				Tileset.Draw(GetTileID(direction), new Point(80 + DrawOffset.X / 4, 110 + DrawOffset.Y / 4));
				Tileset.Scale = new SizeF(2.0f, 2.0f);
				break;
				case ViewFieldPosition.D:
				Tileset.Scale = new SizeF(0.75f, 0.75f);
				Display.Color = Color.Gray;
				Tileset.Draw(GetTileID(direction), new Point(180 + DrawOffset.X / 4, 110 + DrawOffset.Y / 4));
				Tileset.Scale = new SizeF(2.0f, 2.0f);
				break;
				case ViewFieldPosition.E:
				Tileset.Scale = new SizeF(0.75f, 0.75f);
				Display.Color = Color.Gray;
				Tileset.Draw(GetTileID(direction), new Point(270 + DrawOffset.X / 4, 110 + DrawOffset.Y / 4));
				Tileset.Scale = new SizeF(2.0f, 2.0f);
				break;
				case ViewFieldPosition.F:
				Tileset.Scale = new SizeF(0.75f, 0.75f);
				Display.Color = Color.Gray;
				Tileset.Draw(GetTileID(direction), new Point(342 + DrawOffset.X / 4, 110 + DrawOffset.Y / 4));
				Tileset.Scale = new SizeF(2.0f, 2.0f);
				break;



				case ViewFieldPosition.I:
				Tileset.Scale = new SizeF(1.25f, 1.25f);
				Tileset.Draw(GetTileID(direction), new Point(50 + DrawOffset.X / 2, 136 + DrawOffset.Y / 2));
				Tileset.Scale = new SizeF(2.0f, 2.0f);
				break;
				case ViewFieldPosition.J:
				Tileset.Scale = new SizeF(1.25f, 1.25f);
				Tileset.Draw(GetTileID(direction), new Point(180 + DrawOffset.X / 2, 136 + DrawOffset.Y / 2));
				Tileset.Scale = new SizeF(2.0f, 2.0f);
				break;
				case ViewFieldPosition.K:
				Tileset.Scale = new SizeF(1.25f, 1.25f);
				Tileset.Draw(GetTileID(direction), new Point(300 + DrawOffset.X / 2, 136 + DrawOffset.Y / 2));
				Tileset.Scale = new SizeF(2.0f, 2.0f);
				break;


				case ViewFieldPosition.M:
				Tileset.Draw(GetTileID(direction), new Point(-20 + DrawOffset.X, 190));
				break;
				case ViewFieldPosition.N:
				Tileset.Draw(GetTileID(direction), new Point(180 + DrawOffset.X, 190));
				break;
				case ViewFieldPosition.O:
				Tileset.Draw(GetTileID(direction), new Point(370 + DrawOffset.X, 190));
				break;
			}



			Display.Color = Color.White;

			// finish special mode
			if (LastAttack != null && LastAttack.Time + TimeSpan.FromSeconds(0.25) > DateTime.Now)
			{
				Display.TexEnv = mode;
				Display.BlendingFunction(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
			}
		}

		#endregion



		#region Helpers

		/// <summary>
		/// Returns the tile id of the monster depending the view point
		/// </summary>
		/// <param name="from">View direction of the viewer</param>
		/// <returns>ID of the tile to display the monster</returns>
		public int GetTileID(CardinalPoint point)
		{			
			int[,] id = new int[4,4];

			// g	f						LOOKING	  FROM	        VIEW	
			id[0, 0] = 5;			//		N			N			N
			id[0, 1] = 0;			//		N			S			S
			id[0, 2] = 3;			//		N			W			W
			id[0, 3] = 1;			//		N			E			E

			id[1, 0] = 0;			//		S			N			S
			id[1, 1] = 5;			//		S			S			N
			id[1, 2] = 1;			//		S			W			E
			id[1, 3] = 3;			//		S			E			W

			id[2, 0] = 1;			//		W			N			E
			id[2, 1] = 3;			//		W			S			W
			id[2, 2] = 5;			//		W			W			N
			id[2, 3] = 0;			//		W			E			S

			id[3, 0] = 3;			//		E			N			W
			id[3, 1] = 1;			//		E			S			E
			id[3, 2] = 0;			//		E			W			S
			id[3, 3] = 5;			//		E			E			N

			return id[(int)Location.Direction, (int)point] + Tile;
		}



        /// <summary>
        /// Gets if the monster can see the given location
        /// </summary>
        /// <returns>True if the point is in range of sight</returns>
        public bool CanSee(DungeonLocation location)
        {
            if (location == null)
                return false;

            // Not in the same maze
            if (Location.MazeName != location.MazeName)
                return false;

            // Pythagorean
            int a = (Location.Position.X - location.Position.X);
            int b = (Location.Position.Y - location.Position.Y);
            return (a * a + b * b) > SightRange * SightRange;
        }


		#endregion



		#region I/O


		/// <summary>
		/// Loads monster definition
		/// </summary>
		/// <param name="xml">XmlNode handle</param>
		/// <returns></returns>
		public override bool Load(XmlNode xml)
		{
			if (xml == null || xml.Name.ToLower() != "monster")
				return false;

			Name = xml.Attributes["name"].Value;

			foreach (XmlNode node in xml)
			{
				switch (node.Name.ToLower())
				{
					case "location":
					{
						if (Location != null)
							Location.Load(node);
					}
					break;

					case "tiles":
					{
						TileSetName = node.Attributes["name"].Value;
						Tile = int.Parse(node.Attributes["id"].Value);
					}
					break;

					case "pocket":
					{
						ItemsInPocket.Add(node.Attributes["item"].Value);
					}
					break;

					case "script":
					{
						ScriptName = node.Attributes["name"].Value;
						InterfaceName = node.Attributes["interface"].Value;
					}
					break;

					case "damage":
					{
						Damage.Load(node);
					}
					break;

					case "hitdice":
					{
						HitDice.Load(node);
					}
					break;

					case "armorclass":
					{
						ArmorClass = int.Parse(node.Attributes["value"].Value);
					}
					break;

                    case "baseattack":
                    {
                        BaseAttack = int.Parse(node.Attributes["value"].Value);
                    }
                    break;

                    case "sightrange":
                    {
                        SightRange = byte.Parse(node.Attributes["value"].Value);
                    }
                    break;

					case "reward":
					{
						Reward = int.Parse(node.Attributes["value"].Value);
					}
					break;
					
					default:
					{
						base.Load(node);
					}
					break;
				}

			}

			return true;
		}


		/// <summary>
		/// Saves monster definition
		/// </summary>
		/// <param name="writer">XmlWriter handle</param>
		/// <returns></returns>
		public override bool Save(XmlWriter writer)
		{
			if (writer == null)
				return false;

	
			writer.WriteStartElement("monster");
			writer.WriteAttributeString("name", Name);

			base.Save(writer);

			writer.WriteStartElement("script");
			writer.WriteAttributeString("name", ScriptName);
			writer.WriteAttributeString("interface", InterfaceName);
			writer.WriteEndElement();

			if (Location != null)
				Location.Save("location", writer);

			Damage.Save("damage", writer);
			HitDice.Save("hitdice", writer);

			writer.WriteStartElement("tiles");
			writer.WriteAttributeString("name", TileSetName);
			writer.WriteAttributeString("id", Tile.ToString());
			writer.WriteEndElement();

			foreach (string name in ItemsInPocket)
			{
				writer.WriteStartElement("pocket");
				writer.WriteAttributeString("item", name);
				writer.WriteEndElement();
			}

			writer.WriteStartElement("armorclass");
			writer.WriteAttributeString("value", ArmorClass.ToString());
			writer.WriteEndElement();

            writer.WriteStartElement("baseattack");
            writer.WriteAttributeString("value", BaseAttack.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("sightrange");
            writer.WriteAttributeString("value", SightRange.ToString());
            writer.WriteEndElement();

			writer.WriteStartElement("reward");
			writer.WriteAttributeString("value", Reward.ToString());
			writer.WriteEndElement();

			writer.WriteEndElement();

			return true;
		}



		#endregion



		public override string ToString()
		{
			return string.Format("{0}", Name);
		}


		#region Properties

		/// <summary>
		/// Base attack bonus
		/// </summary>
		public int BaseAttack
		{
			get;
			set;
		}


		/// <summary>
		/// Base save bonus
		/// </summary>
		public override int BaseSaveBonus
		{
			get
			{
				return 2 + Experience.GetLevelFromXP(Reward) / 2;
			}
		}


		/// <summary>
		/// Xml tag of the asset in bank
		/// </summary>
		public string XmlTag
		{
			get
			{
				return "monster";
			}
		}


		/// <summary>
		/// Armor class
		/// </summary>
		public override int ArmorClass
		{
			get;
			set;
		}

		/// <summary>
		/// Dice rolled to generate hit points
		/// </summary>
		public Dice HitDice
		{
			get;
			set;
		}


        /// <summary>
        /// Location of the monster
        /// </summary>
        public DungeonLocation Location
        {
            get;
            set;
        }


        /// <summary>
        /// Target location of the monster
        /// </summary>
        public DungeonLocation TargetLocation
        {
			get
			{
				DungeonLocation loc = new DungeonLocation(Location);

				switch (TargetDirection)
				{
					case CardinalPoint.North:
					loc.Position.Y -= TargetRange;
					break;
					case CardinalPoint.South:
					loc.Position.Y += TargetRange;
					break;
					case CardinalPoint.West:
					loc.Position.X -= TargetRange;
					break;
					case CardinalPoint.East:
					loc.Position.X += TargetRange;
					break;
				}

				return loc;
			}
        }


		/// <summary>
		/// Range remaining to reach the target
		/// </summary>
		int TargetRange;


		/// <summary>
		/// Direction of the target
		/// </summary>
		CardinalPoint TargetDirection;


		/// <summary>
		/// Name of the monster
		/// </summary>
		public string Name
		{
			get;
			set;
		}


		/// <summary>
		/// TileSet of the monster
		/// </summary>
		[Browsable(false)]
		public TileSet Tileset
		{
			get;
			protected set;
		}


		/// <summary>
		/// Damage dice
		/// </summary>
		public Dice Damage
		{
			get;
			private set;
		}


		/// <summary>
		/// Holded items droped if killed
		/// </summary>
		public List<string> ItemsInPocket
		{
			get;
			set;
		}

		/// <summary>
		/// The monster can absorb some items when they are thrown at him
		/// </summary>
		public float AbsorbItemRate;


		/// <summary>
		/// State of the monster
		/// </summary>
		public MonsterState State
		{
			get;
			set;
		}


		/// <summary>
		/// Use to alternate frames when the monster walk
		/// </summary>
		public bool SwapFrame;


		/// <summary>
		/// Offset when drawing the monster
		/// </summary>
		Point DrawOffset;


		/// <summary>
		/// Last time a draw offset occured
		/// </summary>
		DateTime LastDrawOffset;


		/// <summary>
		/// Duration of a draw offset.
		/// Smaller the duration is, more the feeling of a over excited monster is
		/// </summary>
		TimeSpan DrawOffsetDuration;


		/// <summary>
		/// Tile id for this monster
		/// </summary>
		[Category("TileSet")]
		public int Tile
		{
			get;
			set;
		}


		/// <summary>
		/// TileSet name to use for this monster
		/// </summary>
		[TypeConverter(typeof(TileSetEnumerator))]
		[Category("TileSet")]
		public string TileSetName
		{
			get;
			set;
		}


		/// <summary>
		/// Defines the size of the creature on the floor. 
		/// </summary>
		/// <remarks>This value is ignored for non material creatures and 
		/// the door always closes normally without causing any damage to such creatures</remarks>
		public MonsterSize Size
		{
			get;
			set;
		}



		/// <summary>
		/// The creature will tend to stay in the back row while other creatures 
		/// will step up to the front row when the party is near and they want to attack
		/// </summary>
		public bool BackRowAttack
		{
			get;
			set;
		}




		/// <summary>
		/// If this bit is set to '1', the creature can pass over pits without falling. 
		/// </summary>
		public bool Levitation
		{
			get;
			set;
		}




		/// <summary>
		/// When sets, the creature can see the party even if it is under the effect of the 'Invisibility' spell. 
		/// </summary>
		public bool CanSeeInvisible
		{
			get;
			set;
		}


		/// <summary>
		/// Last time the team moved
		/// </summary>
		DateTime LastMove
		{
			get;
			set;
		}

		/// <summary>
		/// Does the monster can move
		/// </summary>
		public bool CanMove
		{
			get
			{
				if (LastMove + Speed > DateTime.Now)
					return false;

				return true;
			}
		}



		/// <summary>
		/// Experience gained by killing the entity
		/// </summary>
		public int Reward
		{
			get;
			set;
		}



		/// <summary>
		/// Defines the attack speed of the creature. 
		/// This is the minimum amount of time required between two attacks. 
		/// </summary>
		public TimeSpan AttackSpeed
		{
			get;
			set;
		}


		/// <summary>
		/// Maximum number of tiles between creature and party needed to see the party. 
		/// This applies only if the creature is facing the party.
		/// </summary>
		public byte SightRange
		{
			get;
			set;
		}


		/// <summary>
		/// Maximum number of tiles between creature and party needed to detect 
		/// and "turn" towards the party, perhaps to shoot a projectile. 
		/// This applies even if the creature is not facing the party.
		/// </summary>
		public byte DetectionRange
		{
			get;
			set;
		}




		/// <summary>
		/// Resistance to magical spells like Fireball.
		/// Values range from 0 to 15. Value 15 means the creature is immune.
		/// </summary>
		public byte FireResistance
		{
			get;
			set;
		}



		/// <summary>
		/// Resistance to magical spells involving poison.
		///  Values range from 0 to 15. Value 15 means the creature is immune.
		/// </summary>
		public byte PoisonResistance
		{
			get;
			set;
		}



		/// <summary>
		/// The monster is non material. These creatures ignore normal attacks but take damage from 'Disrupt' spell.
		/// Fire damage is also reduced by a half. All missiles except 'Dispell' pass through these creatures.
		/// These creatures can pass through all doors of any type. 
		/// </summary>
		public bool NonMaterial
		{
			get;
			set;
		}


		/// <summary>
		/// The amount of time while the attack graphic is displayed. 
		/// </summary>
		public TimeSpan AttackDisplayDuration;


		/// <summary>
		/// Name of the sound when the monster move
		/// </summary>
		public string MovementSoundName;

		/// <summary>
		/// Name of the sound when the monster attack
		/// </summary>
		public string AttackSoundName;


		/// <summary>
		/// Script name
		/// </summary>
		public string ScriptName
		{
			get;
			set;
		}

		/// <summary>
		/// Interface name for the script
		/// </summary>
		public string InterfaceName
		{
			get;
			set;
		}


		/// <summary>
		/// Script interface
		/// </summary>
		public IMonster Interface
		{
			get;
			private set;
		}

		#endregion
	}


	/// <summary>
	/// Differents phase of the life of a monster
	/// </summary>
	public enum MonsterState
	{
		/// <summary>
		/// No specific action, wandering in the maze
		/// </summary>
		Inactive,

		/// <summary>
		/// Walking
		/// </summary>
		Walk,

		/// <summary>
		/// Rising weapon to hit the team
		/// </summary>
		RaiseWeapon,

		/// <summary>
		/// Hit the team
		/// </summary>
		Hit,

		/// <summary>
		/// Monster hit by the team
		/// </summary>
		IsHit,


		/// <summary>
		/// The monster try to reach the team to attack them
		/// </summary>
		TrackTeam
	}


	/// <summary>
	/// A size modifier applies to the creature’s Armor Class (AC) and attack bonus,
	/// as well as to certain skills. A creature’s size also determines how far 
	/// it can reach to make a melee attack and how much space it occupies in a block.
	/// </summary>
	public enum MonsterSize
	{
		/// <summary>
		/// means there can be 4 creatures per tile
		/// </summary>
		Small,


		/// <summary>
		/// means there can be 2 creatures per tile
		/// </summary>
		Normal,

		/// <summary>
		/// means there can be only one creature per tile
		/// </summary>
		Big
	}


	/// <summary>
	/// The bigger an opponent is, the easier it is to hit in combat. 
	/// The smaller it is, the harder it is to hit.
	/// </summary>
	public enum MonsterSizeModifier
	{
		/// <summary>
		/// Blue whale
		/// </summary>
		Colossal = -8,

		/// <summary>
		/// Gray whale
		/// </summary>
		Gargantuan = -4,

		/// <summary>
		/// Elephant
		/// </summary>
		Huge = -2,

		/// <summary>
		/// Lion
		/// </summary>
		Large = -1,

		/// <summary>
		/// Human
		/// </summary>
		Medium = 0,

		/// <summary>
		/// German shepherd
		/// </summary>
		Small = 1,

		/// <summary>
		/// House cat
		/// </summary>
		Tiny = 2,

		/// <summary>
		/// Rat
		/// </summary>
		Diminutive = 4,

		/// <summary>
		/// Horsefly
		/// </summary>
		Fine = 8,
	}




	/// <summary>
	/// This value defines what kind of attack the creature uses. 
	/// This value affects how the inflicted damage is computed.
	/// </summary>
	public enum AttackType
	{
		/// <summary>
		/// The creature does not attack champions.
		/// </summary>
		None, 


		/// <summary>
		///  the attacked champion's 'Anti-Fire' characteristic is used to compute damage. 
		/// </summary>
		Fire,


		/// <summary>
		/// The 'Armor Strength' value of the attacked champion's armor is used to compute damage.
		/// </summary>
		Critical, 


		/// <summary>
		/// The 'Armor Strength' value of the attacked champion's armor is used to compute damage. 
		/// </summary>
		Normal, 

		/// <summary>
		/// The 'Sharp resistance' value of the attacked champion's armor is used to compute damage. 
		/// </summary>
		Sharp, 


		/// <summary>
		///  the attacked champion's 'Anti-Magic' characteristic is used to compute damage. 
		/// </summary>
		Magic,


		/// <summary>
		///  the attacked champion's 'Wisdom' characteristic is used to compute damage. 
		/// </summary>
		Psychic,

	}

}
