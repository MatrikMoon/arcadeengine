﻿#region Licence
//
//This file is part of ArcEngine.
//Copyright (C)2008-2009 Adrien Hémery ( iliak@mimicprod.net )
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
using System.Xml;
using System.ComponentModel;
using ArcEngine.Asset;
using ArcEngine;


namespace RuffnTumble
{
	/// <summary>
	/// 
	/// </summary>
	public class SpawnLocation
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		public SpawnLocation()
		{
		}




		#region IO
		/// <summary>
		/// Loads a SpawnPoint definition from bank file
		/// </summary>
		/// <param name="xml"></param>
		/// <returns></returns>
		public bool Load(XmlNode xml)
		{
			if (xml == null)
				return false;

			Name = xml.Attributes["name"].Value;

			foreach (XmlNode node in xml)
			{
				if (node.NodeType == XmlNodeType.Comment)
				{
				//	base.LoadComment(node);
					continue;
				}

				switch (node.Name.ToLower())
				{
					case "location":
					{
						Location = new Vector2(float.Parse(node.Attributes["x"].Value),
							float.Parse(node.Attributes["y"].Value));
					}
					break;

					default:
					{
						Trace.WriteLine("SpawnPoint : Unknown node element found (" + node.Name + ")");
					}
					break;
				}
			}

			return true;
		}


		/// <summary>
		/// Save SpawnPoint defintion to a file bank
		/// </summary>
		/// <param name="xml"></param>
		/// <returns></returns>
		public bool Save(XmlWriter xml)
		{

			xml.WriteStartElement("spawnpoint");
			xml.WriteAttributeString("name", Name);

		//	base.SaveComment(xml);


			xml.WriteStartElement("location");
			xml.WriteAttributeString("x", Location.X.ToString());
			xml.WriteAttributeString("y", Location.Y.ToString());
			xml.WriteEndElement();

			xml.WriteEndElement();

			
			return true;
		}

		#endregion



		#region Properties


		/// <summary>
		/// Name of the spawn location
		/// </summary>
		public string Name
		{
			get;
			set;
		}


		/// <summary>
		/// Offset of the SpawnPoint
		/// </summary>
		public Vector2 Location
		{
			get;
			set;
		}


        /// <summary>
        /// Gets the location of the collision box of the entity (CollisionBox translated
        /// to the entity location in screen coordinate)
        /// </summary>
        [Browsable(false)]
        public Vector4 CollisionBoxLocation
        {
            get
            {
                return new Vector4(
                    Location.X - 8,
                    Location.Y - 8,
                    16,
                    16);
            }
        }


		#endregion
	}
}
