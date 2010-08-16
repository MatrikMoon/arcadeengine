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
using System;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Asset;
using ArcEngine.Graphic;
using ArcEngine.Input;
using System.Collections.Generic;


namespace DungeonEye
{
	/// <summary>
	/// Speel window
	/// </summary>
	public class SpellBook : IDisposable
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public SpellBook()
		{
			SpellLevel = 1;
		}


		/// <summary>
		/// Dispose
		/// </summary>
		public void Dispose()
		{
			if (Font != null)
				Font.Dispose();
			Font = null;

			ResourceManager.RemoveSharedAsset<TileSet>("interface");
			Tileset = null;
		}


		/// <summary>
		/// Loads content
		/// </summary>
		public void LoadContent()
		{
			Font = ResourceManager.CreateAsset<BitmapFont>("inventory");
			Font.GlyphTileset.Scale = new Vector2(2.0f, 2.0f);

			Tileset = ResourceManager.CreateSharedAsset<TileSet>("Interface");
		}



		/// <summary>
		/// Open the Spell Window
		/// </summary>
		/// <param name="hero"></param>
		public void Open(Hero hero)
		{
			if (hero == null)
				return;

			Hero = hero;
			IsVisible = true;
		}


		/// <summary>
		/// Close the Spell Window
		/// </summary>
		public void Close()
		{
			IsVisible = false;
		}


		#region Draw


		/// <summary>
		/// Display the window
		/// </summary>
		/// <param name="batch">Spritebatch to use</param>
		public void Draw(SpriteBatch batch)
		{
			if (!IsVisible)
			return;

			// Main window
			batch.DrawTile(Tileset, 23, new Point(MainRectangle.Location.X, MainRectangle.Location.Y - 2));

			// Levels
			for (int level = 1; level <= 6; level++)
			{
				int id = SpellLevel == level ? 24 : 25;
				batch.DrawTile(Tileset, id, new Point(MainRectangle.X + level * 36 - 36, MainRectangle.Top - 20));
				batch.DrawString(Font, new Point(MainRectangle.X + level * 36 + 12 - 36, MainRectangle.Top - 20 + 4), Color.Black, level.ToString());
			}


			List<Spell> spells = new List<Spell>();
			for(int id = 0; id < Hero.Spells.Count; id++)
			{
				if (Hero.Spells[id].Level == SpellLevel)
					spells.Add(Hero.Spells[id]);
			}

			for (int id = 0; id < Math.Min(spells.Count, 6); id++)
			{
				batch.DrawString(Font, new Point(148, 264 + id * 12), Color.White, spells[id].Name);
			}

			// Abort spell
			batch.DrawTile(Tileset, 30, new Point(142, 336));
			batch.DrawString(Font, new Point(146, 340), Color.Black, "abort spell");

			// Next & previous buttons
			batch.DrawTile(Tileset, 28, new Point(298, 336));
			batch.DrawTile(Tileset, 29, new Point(326, 336));
		}

		#endregion



		#region Update

		/// <summary>
		/// Update the window
		/// </summary>
		/// <param name="time">Game time</param>
		public void Update(GameTime time)
		{
			if (!IsVisible)
				return;

			// Left mouse button
			if (Mouse.IsNewButtonDown(MouseButtons.Left))
			{
				for (int level = 0; level < 6; level++)
				{
					if (new Rectangle(MainRectangle.X + level * 36, MainRectangle.Top - 18, 36, 18).Contains(Mouse.Location))
					{
						SpellLevel = level + 1;
					}
				}


				// Abort spell
				if (new Rectangle(MainRectangle.X + 2, MainRectangle.Bottom - 14, MainRectangle.Width - 56, 18).Contains(Mouse.Location))
					IsVisible = false;


				// Previous line
				if (new Rectangle(298, 336, 30, 18).Contains(Mouse.Location))
				{
				}

				// Next line
				if (new Rectangle(328, 336, 30, 18).Contains(Mouse.Location))
				{
				}
			}


		}

		#endregion

		
		
		#region Properties

		/// <summary>
		/// Concerned hero
		/// </summary>
		public Hero Hero
		{
			get;
			private set;
		}


		/// <summary>
		/// Display font
		/// </summary>
		BitmapFont Font;


		/// <summary>
		/// Rectangle of the window
		/// </summary>
		Rectangle MainRectangle = new Rectangle(142, 262, 210, 88);



		/// <summary>
		/// Spell level selected
		/// </summary>
		public int SpellLevel
		{
			get;
			set;
		}



		/// <summary>
		/// Shows / hides the spell window
		/// </summary>
		public bool IsVisible
		{
			get;
			private set;
		}


		/// <summary>
		/// Tileset
		/// </summary>
		TileSet Tileset;

		#endregion
	}
}
