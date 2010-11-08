﻿namespace DungeonEye.Forms
{
	partial class DungeonForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DungeonForm));
			this.MazePropertyBox = new System.Windows.Forms.PropertyGrid();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.ResetOffsetBox = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.AddMazeButton = new System.Windows.Forms.ToolStripButton();
			this.RemoveMazeButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MazeListBox = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.EditWallButton = new System.Windows.Forms.ToolStripButton();
			this.NoMonstersBox = new System.Windows.Forms.ToolStripButton();
			this.NoGhostsBox = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.CreateNewZoneBox = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.SquareCoordBox = new System.Windows.Forms.ToolStripStatusLabel();
			this.SquareDescriptionBox = new System.Windows.Forms.ToolStripStatusLabel();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.DrawTimer = new System.Windows.Forms.Timer(this.components);
			this.glControl = new OpenTK.GLControl();
			this.StrafeRightBox = new System.Windows.Forms.Button();
			this.TurnRightBox = new System.Windows.Forms.Button();
			this.BackwardBox = new System.Windows.Forms.Button();
			this.ForwardBox = new System.Windows.Forms.Button();
			this.StrafeLeftBox = new System.Windows.Forms.Button();
			this.TurnLeftBox = new System.Windows.Forms.Button();
			this.GlPreviewControl = new OpenTK.GLControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.DungeonMenu = new System.Windows.Forms.MenuStrip();
			this.dungeonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StartLocationMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.PropertiesTab = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.DungeonNoteBox = new System.Windows.Forms.TextBox();
			this.PreviewTab = new System.Windows.Forms.TabPage();
			this.ZonesTab = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ZoneNameBox = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.DisplayZonesBox = new System.Windows.Forms.CheckBox();
			this.MazeZonesBox = new System.Windows.Forms.ListBox();
			this.AddMonsterBox = new System.Windows.Forms.ToolStripButton();
			this.AddItemBox = new System.Windows.Forms.ToolStripButton();
			this.WallBox = new System.Windows.Forms.ToolStripButton();
			this.DoorBox = new System.Windows.Forms.ToolStripButton();
			this.AlcoveBox = new System.Windows.Forms.ToolStripButton();
			this.StairBox = new System.Windows.Forms.ToolStripButton();
			this.TeleporterBox = new System.Windows.Forms.ToolStripButton();
			this.PitBox = new System.Windows.Forms.ToolStripButton();
			this.WrittingBox = new System.Windows.Forms.ToolStripButton();
			this.LauncherBox = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.GeneratorBox = new System.Windows.Forms.ToolStripButton();
			this.SwitchBox = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.FloorSwitchBox = new System.Windows.Forms.ToolStripButton();
			this.EventBox = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.DecorationBox = new System.Windows.Forms.ToolStripButton();
			this.FloorDecorationBox = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.DungeonMenu.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.PropertiesTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.PreviewTab.SuspendLayout();
			this.ZonesTab.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// MazePropertyBox
			// 
			this.MazePropertyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.MazePropertyBox.Location = new System.Drawing.Point(8, 6);
			this.MazePropertyBox.Name = "MazePropertyBox";
			this.MazePropertyBox.Size = new System.Drawing.Size(344, 282);
			this.MazePropertyBox.TabIndex = 1;
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetOffsetBox,
            this.toolStripSeparator4,
            this.AddMazeButton,
            this.RemoveMazeButton,
            this.toolStripSeparator1,
            this.MazeListBox,
            this.toolStripSeparator3,
            this.EditWallButton,
            this.NoMonstersBox,
            this.NoGhostsBox,
            this.toolStripSeparator5,
            this.CreateNewZoneBox,
            this.toolStripSeparator2,
            this.AddMonsterBox,
            this.AddItemBox,
            this.toolStripSeparator6,
            this.WallBox,
            this.DoorBox,
            this.AlcoveBox,
            this.StairBox,
            this.TeleporterBox,
            this.PitBox,
            this.WrittingBox,
            this.LauncherBox,
            this.GeneratorBox,
            this.SwitchBox,
            this.FloorSwitchBox,
            this.toolStripSeparator7,
            this.EventBox,
            this.toolStripSeparator8,
            this.DecorationBox,
            this.FloorDecorationBox});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(865, 25);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// ResetOffsetBox
			// 
			this.ResetOffsetBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ResetOffsetBox.Image = ((System.Drawing.Image)(resources.GetObject("ResetOffsetBox.Image")));
			this.ResetOffsetBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ResetOffsetBox.Name = "ResetOffsetBox";
			this.ResetOffsetBox.Size = new System.Drawing.Size(23, 22);
			this.ResetOffsetBox.Text = "Reset offset";
			this.ResetOffsetBox.Click += new System.EventHandler(this.ResetOffsetBox_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// AddMazeButton
			// 
			this.AddMazeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.AddMazeButton.Image = ((System.Drawing.Image)(resources.GetObject("AddMazeButton.Image")));
			this.AddMazeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddMazeButton.Name = "AddMazeButton";
			this.AddMazeButton.Size = new System.Drawing.Size(23, 22);
			this.AddMazeButton.Text = "Adds a maze...";
			this.AddMazeButton.Click += new System.EventHandler(this.AddMazeButton_Click);
			// 
			// RemoveMazeButton
			// 
			this.RemoveMazeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.RemoveMazeButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveMazeButton.Image")));
			this.RemoveMazeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RemoveMazeButton.Name = "RemoveMazeButton";
			this.RemoveMazeButton.Size = new System.Drawing.Size(23, 22);
			this.RemoveMazeButton.Text = "Removes a maze...";
			this.RemoveMazeButton.Click += new System.EventHandler(this.RemoveMazeButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// MazeListBox
			// 
			this.MazeListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MazeListBox.Name = "MazeListBox";
			this.MazeListBox.Size = new System.Drawing.Size(121, 25);
			this.MazeListBox.Sorted = true;
			this.MazeListBox.SelectedIndexChanged += new System.EventHandler(this.MazeListBox_SelectedIndexChanged);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// EditWallButton
			// 
			this.EditWallButton.CheckOnClick = true;
			this.EditWallButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.EditWallButton.Image = ((System.Drawing.Image)(resources.GetObject("EditWallButton.Image")));
			this.EditWallButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EditWallButton.Name = "EditWallButton";
			this.EditWallButton.Size = new System.Drawing.Size(60, 22);
			this.EditWallButton.Text = "Edit walls";
			this.EditWallButton.Click += new System.EventHandler(this.EditWallButton_Click);
			// 
			// NoMonstersBox
			// 
			this.NoMonstersBox.CheckOnClick = true;
			this.NoMonstersBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.NoMonstersBox.Image = ((System.Drawing.Image)(resources.GetObject("NoMonstersBox.Image")));
			this.NoMonstersBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NoMonstersBox.Name = "NoMonstersBox";
			this.NoMonstersBox.Size = new System.Drawing.Size(79, 22);
			this.NoMonstersBox.Text = "No monsters";
			this.NoMonstersBox.Click += new System.EventHandler(this.NoMonstersBox_Click);
			// 
			// NoGhostsBox
			// 
			this.NoGhostsBox.CheckOnClick = true;
			this.NoGhostsBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.NoGhostsBox.Image = ((System.Drawing.Image)(resources.GetObject("NoGhostsBox.Image")));
			this.NoGhostsBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NoGhostsBox.Name = "NoGhostsBox";
			this.NoGhostsBox.Size = new System.Drawing.Size(65, 22);
			this.NoGhostsBox.Text = "No ghosts";
			this.NoGhostsBox.Click += new System.EventHandler(this.NoGhostsBox_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// CreateNewZoneBox
			// 
			this.CreateNewZoneBox.CheckOnClick = true;
			this.CreateNewZoneBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CreateNewZoneBox.Image = ((System.Drawing.Image)(resources.GetObject("CreateNewZoneBox.Image")));
			this.CreateNewZoneBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CreateNewZoneBox.Name = "CreateNewZoneBox";
			this.CreateNewZoneBox.Size = new System.Drawing.Size(23, 22);
			this.CreateNewZoneBox.Text = "Create a new zone";
			this.CreateNewZoneBox.Click += new System.EventHandler(this.CreateNewZoneBox_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SquareCoordBox,
            this.SquareDescriptionBox});
			this.statusStrip1.Location = new System.Drawing.Point(0, 637);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1256, 24);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// SquareCoordBox
			// 
			this.SquareCoordBox.AutoSize = false;
			this.SquareCoordBox.Name = "SquareCoordBox";
			this.SquareCoordBox.Size = new System.Drawing.Size(250, 19);
			this.SquareCoordBox.Text = "...Location...";
			// 
			// SquareDescriptionBox
			// 
			this.SquareDescriptionBox.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
			this.SquareDescriptionBox.Name = "SquareDescriptionBox";
			this.SquareDescriptionBox.Size = new System.Drawing.Size(991, 19);
			this.SquareDescriptionBox.Spring = true;
			this.SquareDescriptionBox.Text = "...Description...";
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.hScrollBar1.Location = new System.Drawing.Point(368, 622);
			this.hScrollBar1.Maximum = 200;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(868, 17);
			this.hScrollBar1.TabIndex = 4;
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.vScrollBar1.Location = new System.Drawing.Point(1239, 22);
			this.vScrollBar1.Maximum = 200;
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(17, 597);
			this.vScrollBar1.TabIndex = 5;
			// 
			// DrawTimer
			// 
			this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
			// 
			// glControl
			// 
			this.glControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.glControl.BackColor = System.Drawing.Color.Black;
			this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glControl.Location = new System.Drawing.Point(0, 25);
			this.glControl.Name = "glControl";
			this.glControl.Size = new System.Drawing.Size(865, 594);
			this.glControl.TabIndex = 7;
			this.glControl.VSync = false;
			this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControl_Paint);
			this.glControl.DoubleClick += new System.EventHandler(this.glControl_DoubleClick);
			this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlControl_MouseDown);
			this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlControl_MouseMove);
			this.glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GlControl_MouseUp);
			this.glControl.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GlControl_PreviewKeyDown);
			this.glControl.Resize += new System.EventHandler(this.GlControl_Resize);
			// 
			// StrafeRightBox
			// 
			this.StrafeRightBox.AutoSize = true;
			this.StrafeRightBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.StrafeRightBox.Image = ((System.Drawing.Image)(resources.GetObject("StrafeRightBox.Image")));
			this.StrafeRightBox.Location = new System.Drawing.Point(105, 298);
			this.StrafeRightBox.Name = "StrafeRightBox";
			this.StrafeRightBox.Size = new System.Drawing.Size(46, 40);
			this.StrafeRightBox.TabIndex = 3;
			this.StrafeRightBox.UseVisualStyleBackColor = true;
			this.StrafeRightBox.Click += new System.EventHandler(this.StrafeRightBox_Click);
			// 
			// TurnRightBox
			// 
			this.TurnRightBox.AutoSize = true;
			this.TurnRightBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TurnRightBox.Image = ((System.Drawing.Image)(resources.GetObject("TurnRightBox.Image")));
			this.TurnRightBox.Location = new System.Drawing.Point(105, 252);
			this.TurnRightBox.Name = "TurnRightBox";
			this.TurnRightBox.Size = new System.Drawing.Size(46, 40);
			this.TurnRightBox.TabIndex = 3;
			this.TurnRightBox.UseVisualStyleBackColor = true;
			this.TurnRightBox.Click += new System.EventHandler(this.TurnRightBox_Click);
			// 
			// BackwardBox
			// 
			this.BackwardBox.AutoSize = true;
			this.BackwardBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackwardBox.Image = ((System.Drawing.Image)(resources.GetObject("BackwardBox.Image")));
			this.BackwardBox.Location = new System.Drawing.Point(53, 298);
			this.BackwardBox.Name = "BackwardBox";
			this.BackwardBox.Size = new System.Drawing.Size(46, 40);
			this.BackwardBox.TabIndex = 3;
			this.BackwardBox.UseVisualStyleBackColor = true;
			this.BackwardBox.Click += new System.EventHandler(this.BackwardBox_Click);
			// 
			// ForwardBox
			// 
			this.ForwardBox.AutoSize = true;
			this.ForwardBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ForwardBox.Image = ((System.Drawing.Image)(resources.GetObject("ForwardBox.Image")));
			this.ForwardBox.Location = new System.Drawing.Point(53, 252);
			this.ForwardBox.Name = "ForwardBox";
			this.ForwardBox.Size = new System.Drawing.Size(46, 40);
			this.ForwardBox.TabIndex = 3;
			this.ForwardBox.UseVisualStyleBackColor = true;
			this.ForwardBox.Click += new System.EventHandler(this.ForwardBox_Click);
			// 
			// StrafeLeftBox
			// 
			this.StrafeLeftBox.AutoSize = true;
			this.StrafeLeftBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.StrafeLeftBox.Image = ((System.Drawing.Image)(resources.GetObject("StrafeLeftBox.Image")));
			this.StrafeLeftBox.Location = new System.Drawing.Point(3, 298);
			this.StrafeLeftBox.Name = "StrafeLeftBox";
			this.StrafeLeftBox.Size = new System.Drawing.Size(44, 40);
			this.StrafeLeftBox.TabIndex = 3;
			this.StrafeLeftBox.UseVisualStyleBackColor = true;
			this.StrafeLeftBox.Click += new System.EventHandler(this.StrafeLeftBox_Click);
			// 
			// TurnLeftBox
			// 
			this.TurnLeftBox.AutoSize = true;
			this.TurnLeftBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TurnLeftBox.Image = ((System.Drawing.Image)(resources.GetObject("TurnLeftBox.Image")));
			this.TurnLeftBox.Location = new System.Drawing.Point(3, 252);
			this.TurnLeftBox.Name = "TurnLeftBox";
			this.TurnLeftBox.Size = new System.Drawing.Size(44, 40);
			this.TurnLeftBox.TabIndex = 3;
			this.TurnLeftBox.UseVisualStyleBackColor = true;
			this.TurnLeftBox.Click += new System.EventHandler(this.TurnLeftBox_Click);
			// 
			// GlPreviewControl
			// 
			this.GlPreviewControl.BackColor = System.Drawing.Color.Black;
			this.GlPreviewControl.Location = new System.Drawing.Point(3, 6);
			this.GlPreviewControl.Name = "GlPreviewControl";
			this.GlPreviewControl.Size = new System.Drawing.Size(352, 240);
			this.GlPreviewControl.TabIndex = 2;
			this.GlPreviewControl.VSync = false;
			this.GlPreviewControl.Load += new System.EventHandler(this.GlPreviewControl_Load);
			this.GlPreviewControl.Paint += new System.Windows.Forms.PaintEventHandler(this.GlPreviewControl_Paint);
			this.GlPreviewControl.Resize += new System.EventHandler(this.GlPreviewControl_Resize);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.glControl);
			this.panel1.Controls.Add(this.toolStrip1);
			this.panel1.Location = new System.Drawing.Point(371, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(865, 619);
			this.panel1.TabIndex = 9;
			// 
			// DungeonMenu
			// 
			this.DungeonMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dungeonToolStripMenuItem});
			this.DungeonMenu.Location = new System.Drawing.Point(0, 0);
			this.DungeonMenu.Name = "DungeonMenu";
			this.DungeonMenu.Size = new System.Drawing.Size(1256, 24);
			this.DungeonMenu.TabIndex = 10;
			this.DungeonMenu.Text = "Dungeon";
			// 
			// dungeonToolStripMenuItem
			// 
			this.dungeonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartLocationMenu});
			this.dungeonToolStripMenuItem.Name = "dungeonToolStripMenuItem";
			this.dungeonToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.dungeonToolStripMenuItem.Text = "Dungeon";
			// 
			// StartLocationMenu
			// 
			this.StartLocationMenu.Name = "StartLocationMenu";
			this.StartLocationMenu.Size = new System.Drawing.Size(172, 22);
			this.StartLocationMenu.Text = "Mark as start point";
			this.StartLocationMenu.Click += new System.EventHandler(this.StartLocationMenu_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.tabControl1.Controls.Add(this.PropertiesTab);
			this.tabControl1.Controls.Add(this.PreviewTab);
			this.tabControl1.Controls.Add(this.ZonesTab);
			this.tabControl1.Location = new System.Drawing.Point(0, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(365, 612);
			this.tabControl1.TabIndex = 11;
			// 
			// PropertiesTab
			// 
			this.PropertiesTab.Controls.Add(this.groupBox1);
			this.PropertiesTab.Controls.Add(this.MazePropertyBox);
			this.PropertiesTab.Location = new System.Drawing.Point(4, 22);
			this.PropertiesTab.Name = "PropertiesTab";
			this.PropertiesTab.Padding = new System.Windows.Forms.Padding(3);
			this.PropertiesTab.Size = new System.Drawing.Size(357, 586);
			this.PropertiesTab.TabIndex = 0;
			this.PropertiesTab.Text = "Properties";
			this.PropertiesTab.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.DungeonNoteBox);
			this.groupBox1.Location = new System.Drawing.Point(6, 294);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(346, 286);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Notes :";
			// 
			// DungeonNoteBox
			// 
			this.DungeonNoteBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DungeonNoteBox.Location = new System.Drawing.Point(3, 16);
			this.DungeonNoteBox.Multiline = true;
			this.DungeonNoteBox.Name = "DungeonNoteBox";
			this.DungeonNoteBox.Size = new System.Drawing.Size(340, 267);
			this.DungeonNoteBox.TabIndex = 0;
			this.DungeonNoteBox.TextChanged += new System.EventHandler(this.DungeonNoteBox_TextChanged);
			// 
			// PreviewTab
			// 
			this.PreviewTab.Controls.Add(this.StrafeRightBox);
			this.PreviewTab.Controls.Add(this.TurnRightBox);
			this.PreviewTab.Controls.Add(this.GlPreviewControl);
			this.PreviewTab.Controls.Add(this.BackwardBox);
			this.PreviewTab.Controls.Add(this.TurnLeftBox);
			this.PreviewTab.Controls.Add(this.ForwardBox);
			this.PreviewTab.Controls.Add(this.StrafeLeftBox);
			this.PreviewTab.Location = new System.Drawing.Point(4, 22);
			this.PreviewTab.Name = "PreviewTab";
			this.PreviewTab.Padding = new System.Windows.Forms.Padding(3);
			this.PreviewTab.Size = new System.Drawing.Size(357, 586);
			this.PreviewTab.TabIndex = 1;
			this.PreviewTab.Text = "Preview";
			this.PreviewTab.UseVisualStyleBackColor = true;
			// 
			// ZonesTab
			// 
			this.ZonesTab.Controls.Add(this.groupBox2);
			this.ZonesTab.Controls.Add(this.button2);
			this.ZonesTab.Controls.Add(this.DisplayZonesBox);
			this.ZonesTab.Controls.Add(this.MazeZonesBox);
			this.ZonesTab.Location = new System.Drawing.Point(4, 22);
			this.ZonesTab.Name = "ZonesTab";
			this.ZonesTab.Size = new System.Drawing.Size(357, 586);
			this.ZonesTab.TabIndex = 2;
			this.ZonesTab.Text = "Zones";
			this.ZonesTab.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.ZoneNameBox);
			this.groupBox2.Location = new System.Drawing.Point(8, 208);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(346, 362);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Properties :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Name :";
			// 
			// ZoneNameBox
			// 
			this.ZoneNameBox.Location = new System.Drawing.Point(56, 19);
			this.ZoneNameBox.Name = "ZoneNameBox";
			this.ZoneNameBox.Size = new System.Drawing.Size(201, 20);
			this.ZoneNameBox.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 179);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Remove";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// DisplayZonesBox
			// 
			this.DisplayZonesBox.AutoSize = true;
			this.DisplayZonesBox.Location = new System.Drawing.Point(134, 15);
			this.DisplayZonesBox.Name = "DisplayZonesBox";
			this.DisplayZonesBox.Size = new System.Drawing.Size(48, 17);
			this.DisplayZonesBox.TabIndex = 3;
			this.DisplayZonesBox.Text = "Hide";
			this.DisplayZonesBox.UseVisualStyleBackColor = true;
			// 
			// MazeZonesBox
			// 
			this.MazeZonesBox.FormattingEnabled = true;
			this.MazeZonesBox.Location = new System.Drawing.Point(8, 3);
			this.MazeZonesBox.Name = "MazeZonesBox";
			this.MazeZonesBox.Size = new System.Drawing.Size(120, 173);
			this.MazeZonesBox.Sorted = true;
			this.MazeZonesBox.TabIndex = 0;
			// 
			// AddMonsterBox
			// 
			this.AddMonsterBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.AddMonsterBox.Image = ((System.Drawing.Image)(resources.GetObject("AddMonsterBox.Image")));
			this.AddMonsterBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddMonsterBox.Name = "AddMonsterBox";
			this.AddMonsterBox.Size = new System.Drawing.Size(23, 22);
			this.AddMonsterBox.Text = "Add monster...";
			// 
			// AddItemBox
			// 
			this.AddItemBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.AddItemBox.Image = ((System.Drawing.Image)(resources.GetObject("AddItemBox.Image")));
			this.AddItemBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddItemBox.Name = "AddItemBox";
			this.AddItemBox.Size = new System.Drawing.Size(23, 22);
			this.AddItemBox.Text = "Add item...";
			// 
			// WallBox
			// 
			this.WallBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.WallBox.Image = ((System.Drawing.Image)(resources.GetObject("WallBox.Image")));
			this.WallBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.WallBox.Name = "WallBox";
			this.WallBox.Size = new System.Drawing.Size(23, 22);
			this.WallBox.Text = "Wall";
			// 
			// DoorBox
			// 
			this.DoorBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.DoorBox.Image = ((System.Drawing.Image)(resources.GetObject("DoorBox.Image")));
			this.DoorBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DoorBox.Name = "DoorBox";
			this.DoorBox.Size = new System.Drawing.Size(23, 22);
			this.DoorBox.Text = "Door";
			// 
			// AlcoveBox
			// 
			this.AlcoveBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.AlcoveBox.Image = ((System.Drawing.Image)(resources.GetObject("AlcoveBox.Image")));
			this.AlcoveBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AlcoveBox.Name = "AlcoveBox";
			this.AlcoveBox.Size = new System.Drawing.Size(23, 22);
			this.AlcoveBox.Text = "Alcove...";
			// 
			// StairBox
			// 
			this.StairBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.StairBox.Image = ((System.Drawing.Image)(resources.GetObject("StairBox.Image")));
			this.StairBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.StairBox.Name = "StairBox";
			this.StairBox.Size = new System.Drawing.Size(23, 22);
			this.StairBox.Text = "Stair...";
			// 
			// TeleporterBox
			// 
			this.TeleporterBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TeleporterBox.Image = ((System.Drawing.Image)(resources.GetObject("TeleporterBox.Image")));
			this.TeleporterBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TeleporterBox.Name = "TeleporterBox";
			this.TeleporterBox.Size = new System.Drawing.Size(23, 22);
			this.TeleporterBox.Text = "Teleporter...";
			// 
			// PitBox
			// 
			this.PitBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PitBox.Image = ((System.Drawing.Image)(resources.GetObject("PitBox.Image")));
			this.PitBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PitBox.Name = "PitBox";
			this.PitBox.Size = new System.Drawing.Size(23, 22);
			this.PitBox.Text = "Pit...";
			// 
			// WrittingBox
			// 
			this.WrittingBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.WrittingBox.Image = ((System.Drawing.Image)(resources.GetObject("WrittingBox.Image")));
			this.WrittingBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.WrittingBox.Name = "WrittingBox";
			this.WrittingBox.Size = new System.Drawing.Size(23, 22);
			this.WrittingBox.Text = "Writting...";
			// 
			// LauncherBox
			// 
			this.LauncherBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.LauncherBox.Image = ((System.Drawing.Image)(resources.GetObject("LauncherBox.Image")));
			this.LauncherBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.LauncherBox.Name = "LauncherBox";
			this.LauncherBox.Size = new System.Drawing.Size(23, 22);
			this.LauncherBox.Text = "Launcher...";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// GeneratorBox
			// 
			this.GeneratorBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.GeneratorBox.Image = ((System.Drawing.Image)(resources.GetObject("GeneratorBox.Image")));
			this.GeneratorBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.GeneratorBox.Name = "GeneratorBox";
			this.GeneratorBox.Size = new System.Drawing.Size(23, 22);
			this.GeneratorBox.Text = "Generator...";
			// 
			// SwitchBox
			// 
			this.SwitchBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SwitchBox.Image = ((System.Drawing.Image)(resources.GetObject("SwitchBox.Image")));
			this.SwitchBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SwitchBox.Name = "SwitchBox";
			this.SwitchBox.Size = new System.Drawing.Size(23, 22);
			this.SwitchBox.Text = "Switch...";
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// FloorSwitchBox
			// 
			this.FloorSwitchBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.FloorSwitchBox.Image = ((System.Drawing.Image)(resources.GetObject("FloorSwitchBox.Image")));
			this.FloorSwitchBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.FloorSwitchBox.Name = "FloorSwitchBox";
			this.FloorSwitchBox.Size = new System.Drawing.Size(23, 22);
			this.FloorSwitchBox.Text = "Floor switch...";
			// 
			// EventBox
			// 
			this.EventBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.EventBox.Image = ((System.Drawing.Image)(resources.GetObject("EventBox.Image")));
			this.EventBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EventBox.Name = "EventBox";
			this.EventBox.Size = new System.Drawing.Size(23, 22);
			this.EventBox.Text = "Event...";
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
			// 
			// DecorationBox
			// 
			this.DecorationBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.DecorationBox.Image = ((System.Drawing.Image)(resources.GetObject("DecorationBox.Image")));
			this.DecorationBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DecorationBox.Name = "DecorationBox";
			this.DecorationBox.Size = new System.Drawing.Size(23, 22);
			this.DecorationBox.Text = "Decoration...";
			// 
			// FloorDecorationBox
			// 
			this.FloorDecorationBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.FloorDecorationBox.Image = ((System.Drawing.Image)(resources.GetObject("FloorDecorationBox.Image")));
			this.FloorDecorationBox.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.FloorDecorationBox.Name = "FloorDecorationBox";
			this.FloorDecorationBox.Size = new System.Drawing.Size(23, 22);
			this.FloorDecorationBox.Text = "Floor decoration...";
			// 
			// DungeonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1256, 661);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.vScrollBar1);
			this.Controls.Add(this.hScrollBar1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.DungeonMenu);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.DungeonMenu;
			this.Name = "DungeonForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.TabText = "Dungeon Form";
			this.Text = "Dungeon Form";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DungeonForm_FormClosing);
			this.Load += new System.EventHandler(this.DungeonForm_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.DungeonMenu.ResumeLayout(false);
			this.DungeonMenu.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.PropertiesTab.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.PreviewTab.ResumeLayout(false);
			this.PreviewTab.PerformLayout();
			this.ZonesTab.ResumeLayout(false);
			this.ZonesTab.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton AddMazeButton;
		private System.Windows.Forms.ToolStripButton RemoveMazeButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox MazeListBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton EditWallButton;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel SquareCoordBox;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.PropertyGrid MazePropertyBox;
		private System.Windows.Forms.ToolStripButton ResetOffsetBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.Timer DrawTimer;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private OpenTK.GLControl glControl;
		private OpenTK.GLControl GlPreviewControl;
		private System.Windows.Forms.Button StrafeRightBox;
		private System.Windows.Forms.Button TurnRightBox;
		private System.Windows.Forms.Button BackwardBox;
		private System.Windows.Forms.Button ForwardBox;
		private System.Windows.Forms.Button StrafeLeftBox;
		private System.Windows.Forms.Button TurnLeftBox;
		private System.Windows.Forms.ToolStripStatusLabel SquareDescriptionBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip DungeonMenu;
		private System.Windows.Forms.ToolStripMenuItem dungeonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem StartLocationMenu;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage PropertiesTab;
		private System.Windows.Forms.TabPage PreviewTab;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox DungeonNoteBox;
		private System.Windows.Forms.TabPage ZonesTab;
		private System.Windows.Forms.ListBox MazeZonesBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox DisplayZonesBox;
		private System.Windows.Forms.ToolStripButton CreateNewZoneBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ZoneNameBox;
		private System.Windows.Forms.ToolStripButton NoMonstersBox;
		private System.Windows.Forms.ToolStripButton NoGhostsBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton AddMonsterBox;
		private System.Windows.Forms.ToolStripButton AddItemBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton WallBox;
		private System.Windows.Forms.ToolStripButton DoorBox;
		private System.Windows.Forms.ToolStripButton AlcoveBox;
		private System.Windows.Forms.ToolStripButton StairBox;
		private System.Windows.Forms.ToolStripButton TeleporterBox;
		private System.Windows.Forms.ToolStripButton PitBox;
		private System.Windows.Forms.ToolStripButton WrittingBox;
		private System.Windows.Forms.ToolStripButton LauncherBox;
		private System.Windows.Forms.ToolStripButton GeneratorBox;
		private System.Windows.Forms.ToolStripButton SwitchBox;
		private System.Windows.Forms.ToolStripButton FloorSwitchBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton EventBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripButton DecorationBox;
		private System.Windows.Forms.ToolStripButton FloorDecorationBox;
	}
}