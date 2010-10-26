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
using System.Collections.Generic;
using System.IO;
using System.Xml;


namespace ArcEngine.Storage
{
	/// <summary>
	/// Filesystem storage
	/// </summary>
	public class FileSystemStorage : StorageBase
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="path">Directory path</param>
		public FileSystemStorage(string path)
		{
			StoragePath = path;

			Process();
		}


		/// <summary>
		/// Dispose resource
		/// </summary>
		public override void Dispose()
		{
		}


		/// <summary>
		/// Opens a file at a specified path 
		/// </summary>
		/// <param name="name">Relative path of the file </param>
		/// <returns>Stream handle or null</returns>
		public override Stream OpenFile(string name)
		{
			string filename = Path.Combine(StoragePath, name);

			if (!File.Exists(filename))
				return null;

			return new FileStream(filename, FileMode.Open, FileAccess.Read);
		}



		/// <summary>
		/// Process all file in the storage
		/// </summary>
		/// <returns>True on succes</returns>
		public override bool Process()
		{
			Files.Clear();

			// Add files to the list
			DirectoryInfo di = new DirectoryInfo(StoragePath);
			foreach (FileInfo fi in di.GetFiles("*", SearchOption.AllDirectories))
			{
				// Adds file to the list
				Files.Add(fi.FullName.Replace(StoragePath, string.Empty));


				if (!fi.FullName.EndsWith(".xml", true, null))
					continue;

				// Convert to xml
				XmlDocument doc = new XmlDocument();
				doc.Load(fi.FullName);


				// Check the root node
				XmlElement xml = doc.DocumentElement;
				if (xml.Name.ToLower() != "bank")
				{
					Trace.WriteLine("");
					continue;
				}


				// For each nodes, process it
				foreach (XmlNode node in xml.ChildNodes)
				{
					if (node.NodeType == XmlNodeType.Comment)
						continue;


					Provider provider = ResourceManager.GetTagProvider(node.Name);
					if (provider == null)
					{
						Trace.WriteLine("? No Provider found for asset \"<" + node.Name + ">\"...");
						continue;
					}

					//lock (BinaryLock)
					{
						provider.Load(node);
					}
				}

				Trace.WriteLine("");


			}



			return true;
		}



		#region Properties

		/// <summary>
		/// Storage path
		/// </summary>
		string StoragePath;

		#endregion
	}
}