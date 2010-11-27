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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArcEngine.Forms;
using ArcEngine;
using System.IO;

namespace DungeonEye.Forms
{
	/// <summary>
	/// Square event editor form
	/// </summary>
	public partial class EventSquareForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="eventsquare">EventSquare handle</param>
		/// <param name="dungeon">Dungeon handle</param>
		public EventSquareForm(EventSquare eventsquare, Dungeon dungeon)
		{
			InitializeComponent();


			DirectionBox.DataSource = Enum.GetValues(typeof(CardinalPoint));
			DirectionBox.SelectedItem = eventsquare.Direction;
			DisplayBackgroundBox.Checked = eventsquare.DisplayBackground;
	
			EventSquare = eventsquare;
		}



		#region Form events

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EventSquareForm_Load(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			DirectionBox.Enabled = EventSquare.MustFace;
			MustFaceBox.Checked = EventSquare.MustFace;
			MessageBox.Text = EventSquare.Message;
			LoopSoundBox.Checked = EventSquare.LoopSound;
			SoundNameBox.Text = EventSquare.SoundName;
			PictureNameBox.Text = EventSquare.PictureName;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PictureNameBox_TextChanged(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			EventSquare.PictureName = PictureNameBox.Text;
		}

	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BrowsePictureBox_Click(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			StorageBrowserForm form = new StorageBrowserForm();
			form.MultiSelect = false;
			if (form.ShowDialog() != DialogResult.OK)
				return;

			PictureNameBox.Text = form.FileName;

			Stream stream = ResourceManager.Load(form.FileName);
			if (stream != null)
				PreviewBox.Image = Image.FromStream(stream);
			stream.Close();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MustFaceBox_CheckedChanged(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			EventSquare.MustFace = MustFaceBox.Checked;
			DirectionBox.Enabled = MustFaceBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DirectionBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			EventSquare.Direction = (CardinalPoint)DirectionBox.SelectedItem;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SoundNameBox_TextChanged(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			EventSquare.SoundName = SoundNameBox.Text;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MessageBox_TextChanged(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			EventSquare.Message = MessageBox.Text;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BrowseSoundBox_Click(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			StorageBrowserForm form = new StorageBrowserForm();
			form.MultiSelect = false;
			if (form.ShowDialog() != DialogResult.OK)
				return;

			SoundNameBox.Text = form.FileName;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EventSquareForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoopSoundBox_CheckedChanged(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			EventSquare.LoopSound = LoopSoundBox.Checked;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DisplayBackgroundBox_CheckedChanged(object sender, EventArgs e)
		{
			if (EventSquare == null)
				return;

			EventSquare.DisplayBackground = DisplayBackgroundBox.Checked;

		}


		#endregion


		#region Properties

		/// <summary>
		/// 
		/// </summary>
		EventSquare EventSquare;

		#endregion


	}
}
