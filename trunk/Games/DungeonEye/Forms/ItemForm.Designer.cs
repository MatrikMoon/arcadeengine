﻿namespace DungeonEye.Forms
{
	partial class ItemForm
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
			DungeonEye.Dice dice1 = new DungeonEye.Dice();
			this.GLGroundTile = new OpenTK.GLControl();
			this.GLInventoryTile = new OpenTK.GLControl();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.GroundTileBox = new System.Windows.Forms.ComboBox();
			this.InventoryTileBox = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.DescriptionBox = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.UseQuiverBox = new System.Windows.Forms.CheckBox();
			this.ACBonusBox = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.RangeBox = new System.Windows.Forms.NumericUpDown();
			this.TwoHandedBox = new System.Windows.Forms.CheckBox();
			this.WeightBox = new System.Windows.Forms.NumericUpDown();
			this.SpeedBox = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.Weight = new System.Windows.Forms.Label();
			this.TypeBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.WaistBox = new System.Windows.Forms.CheckBox();
			this.HeadBox = new System.Windows.Forms.CheckBox();
			this.FeetBox = new System.Windows.Forms.CheckBox();
			this.WristBox = new System.Windows.Forms.CheckBox();
			this.RingBox = new System.Windows.Forms.CheckBox();
			this.BodyBox = new System.Windows.Forms.CheckBox();
			this.NeckBox = new System.Windows.Forms.CheckBox();
			this.SecondaryBox = new System.Windows.Forms.CheckBox();
			this.QuiverBox = new System.Windows.Forms.CheckBox();
			this.PrimaryBox = new System.Windows.Forms.CheckBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.MultiplierBox = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.CriticalMaxBox = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.CriticalMinBox = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.GLIncomingTile = new OpenTK.GLControl();
			this.GLThrownTile = new OpenTK.GLControl();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.TileSetNameBox = new System.Windows.Forms.ComboBox();
			this.IncomingTileBox = new System.Windows.Forms.ComboBox();
			this.ThrownTileBox = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.ThiefBox = new System.Windows.Forms.CheckBox();
			this.MageBox = new System.Windows.Forms.CheckBox();
			this.ClericBox = new System.Windows.Forms.CheckBox();
			this.RangerBox = new System.Windows.Forms.CheckBox();
			this.PaladinBox = new System.Windows.Forms.CheckBox();
			this.FighterBox = new System.Windows.Forms.CheckBox();
			this.InterfaceNameBox = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.ScriptNameBox = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.VisualTab = new System.Windows.Forms.TabPage();
			this.PropertiesTab = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SlashBox = new System.Windows.Forms.CheckBox();
			this.BludgeBox = new System.Windows.Forms.CheckBox();
			this.PiercingBox = new System.Windows.Forms.CheckBox();
			this.ScriptTab = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.DamageBox = new DungeonEye.Forms.DiceForm();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.ACBonusBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.RangeBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.WeightBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.SpeedBox)).BeginInit();
			this.groupBox6.SuspendLayout();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.MultiplierBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.CriticalMaxBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.CriticalMinBox)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.VisualTab.SuspendLayout();
			this.PropertiesTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.ScriptTab.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.SuspendLayout();
			// 
			// GLGroundTile
			// 
			this.GLGroundTile.BackColor = System.Drawing.Color.Black;
			this.GLGroundTile.Location = new System.Drawing.Point(200, 73);
			this.GLGroundTile.Name = "GLGroundTile";
			this.GLGroundTile.Size = new System.Drawing.Size(181, 165);
			this.GLGroundTile.TabIndex = 2;
			this.GLGroundTile.VSync = true;
			this.GLGroundTile.Load += new System.EventHandler(this.GLGroundTile_Load);
			this.GLGroundTile.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Tiles);
			this.GLGroundTile.Resize += new System.EventHandler(this.GLGroundTile_Resize);
			// 
			// GLInventoryTile
			// 
			this.GLInventoryTile.BackColor = System.Drawing.Color.Black;
			this.GLInventoryTile.Location = new System.Drawing.Point(6, 73);
			this.GLInventoryTile.Name = "GLInventoryTile";
			this.GLInventoryTile.Size = new System.Drawing.Size(181, 165);
			this.GLInventoryTile.TabIndex = 2;
			this.GLInventoryTile.VSync = true;
			this.GLInventoryTile.Load += new System.EventHandler(this.GLInventoryTile_Load);
			this.GLInventoryTile.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Tiles);
			this.GLInventoryTile.Resize += new System.EventHandler(this.GLInventoryTile_Resize);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(206, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ground :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Inventory :";
			// 
			// GroundTileBox
			// 
			this.GroundTileBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GroundTileBox.FormattingEnabled = true;
			this.GroundTileBox.Location = new System.Drawing.Point(259, 46);
			this.GroundTileBox.Name = "GroundTileBox";
			this.GroundTileBox.Size = new System.Drawing.Size(121, 21);
			this.GroundTileBox.TabIndex = 0;
			this.GroundTileBox.SelectedIndexChanged += new System.EventHandler(this.GroundTileID_OnChange);
			// 
			// InventoryTileBox
			// 
			this.InventoryTileBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InventoryTileBox.FormattingEnabled = true;
			this.InventoryTileBox.Location = new System.Drawing.Point(66, 46);
			this.InventoryTileBox.Name = "InventoryTileBox";
			this.InventoryTileBox.Size = new System.Drawing.Size(121, 21);
			this.InventoryTileBox.TabIndex = 0;
			this.InventoryTileBox.SelectedIndexChanged += new System.EventHandler(this.InventoryTileID_OnChange);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.DescriptionBox);
			this.groupBox4.Location = new System.Drawing.Point(3, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(460, 105);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Description :";
			// 
			// DescriptionBox
			// 
			this.DescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DescriptionBox.Location = new System.Drawing.Point(3, 16);
			this.DescriptionBox.Multiline = true;
			this.DescriptionBox.Name = "DescriptionBox";
			this.DescriptionBox.Size = new System.Drawing.Size(454, 86);
			this.DescriptionBox.TabIndex = 4;
			this.DescriptionBox.TextChanged += new System.EventHandler(this.DescriptionBox_TextChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.UseQuiverBox);
			this.groupBox5.Controls.Add(this.ACBonusBox);
			this.groupBox5.Controls.Add(this.label14);
			this.groupBox5.Controls.Add(this.RangeBox);
			this.groupBox5.Controls.Add(this.TwoHandedBox);
			this.groupBox5.Controls.Add(this.WeightBox);
			this.groupBox5.Controls.Add(this.SpeedBox);
			this.groupBox5.Controls.Add(this.label3);
			this.groupBox5.Controls.Add(this.Weight);
			this.groupBox5.Controls.Add(this.TypeBox);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Location = new System.Drawing.Point(3, 117);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(252, 218);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Misc :";
			// 
			// UseQuiverBox
			// 
			this.UseQuiverBox.AutoSize = true;
			this.UseQuiverBox.Location = new System.Drawing.Point(167, 44);
			this.UseQuiverBox.Name = "UseQuiverBox";
			this.UseQuiverBox.Size = new System.Drawing.Size(77, 17);
			this.UseQuiverBox.TabIndex = 10;
			this.UseQuiverBox.Text = "Use quiver";
			this.UseQuiverBox.UseVisualStyleBackColor = true;
			this.UseQuiverBox.CheckedChanged += new System.EventHandler(this.UseQuiverBox_CheckedChanged);
			// 
			// ACBonusBox
			// 
			this.ACBonusBox.Location = new System.Drawing.Point(70, 122);
			this.ACBonusBox.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
			this.ACBonusBox.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
			this.ACBonusBox.Name = "ACBonusBox";
			this.ACBonusBox.Size = new System.Drawing.Size(77, 20);
			this.ACBonusBox.TabIndex = 2;
			this.ACBonusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ACBonusBox.ValueChanged += new System.EventHandler(this.ACBonusBox_ValueChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(4, 126);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(60, 13);
			this.label14.TabIndex = 1;
			this.label14.Text = "AC Bonus :";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// RangeBox
			// 
			this.RangeBox.Location = new System.Drawing.Point(70, 96);
			this.RangeBox.Name = "RangeBox";
			this.RangeBox.Size = new System.Drawing.Size(77, 20);
			this.RangeBox.TabIndex = 4;
			this.RangeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.RangeBox.ThousandsSeparator = true;
			this.RangeBox.ValueChanged += new System.EventHandler(this.RangeBox_ValueChanged);
			// 
			// TwoHandedBox
			// 
			this.TwoHandedBox.AutoSize = true;
			this.TwoHandedBox.Location = new System.Drawing.Point(167, 21);
			this.TwoHandedBox.Name = "TwoHandedBox";
			this.TwoHandedBox.Size = new System.Drawing.Size(79, 17);
			this.TwoHandedBox.TabIndex = 0;
			this.TwoHandedBox.Text = "Two hands";
			this.TwoHandedBox.UseVisualStyleBackColor = true;
			this.TwoHandedBox.CheckedChanged += new System.EventHandler(this.TwoHandedBox_CheckedChanged);
			// 
			// WeightBox
			// 
			this.WeightBox.Location = new System.Drawing.Point(70, 70);
			this.WeightBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.WeightBox.Name = "WeightBox";
			this.WeightBox.Size = new System.Drawing.Size(77, 20);
			this.WeightBox.TabIndex = 2;
			this.WeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.WeightBox.ThousandsSeparator = true;
			this.WeightBox.ValueChanged += new System.EventHandler(this.WeightBox_ValueChanged);
			// 
			// SpeedBox
			// 
			this.SpeedBox.Location = new System.Drawing.Point(70, 44);
			this.SpeedBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.SpeedBox.Name = "SpeedBox";
			this.SpeedBox.Size = new System.Drawing.Size(77, 20);
			this.SpeedBox.TabIndex = 2;
			this.SpeedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.SpeedBox.ThousandsSeparator = true;
			this.SpeedBox.ValueChanged += new System.EventHandler(this.SpeedBox_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Range :";
			// 
			// Weight
			// 
			this.Weight.AutoSize = true;
			this.Weight.Location = new System.Drawing.Point(17, 72);
			this.Weight.Name = "Weight";
			this.Weight.Size = new System.Drawing.Size(47, 13);
			this.Weight.TabIndex = 1;
			this.Weight.Text = "Weight :";
			// 
			// TypeBox
			// 
			this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeBox.FormattingEnabled = true;
			this.TypeBox.Location = new System.Drawing.Point(70, 19);
			this.TypeBox.Name = "TypeBox";
			this.TypeBox.Size = new System.Drawing.Size(77, 21);
			this.TypeBox.Sorted = true;
			this.TypeBox.TabIndex = 0;
			this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Speed :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Type :";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.WaistBox);
			this.groupBox6.Controls.Add(this.HeadBox);
			this.groupBox6.Controls.Add(this.FeetBox);
			this.groupBox6.Controls.Add(this.WristBox);
			this.groupBox6.Controls.Add(this.RingBox);
			this.groupBox6.Controls.Add(this.BodyBox);
			this.groupBox6.Controls.Add(this.NeckBox);
			this.groupBox6.Controls.Add(this.SecondaryBox);
			this.groupBox6.Controls.Add(this.QuiverBox);
			this.groupBox6.Controls.Add(this.PrimaryBox);
			this.groupBox6.Location = new System.Drawing.Point(261, 117);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(202, 142);
			this.groupBox6.TabIndex = 7;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Allowed slots :";
			// 
			// WaistBox
			// 
			this.WaistBox.AutoSize = true;
			this.WaistBox.Location = new System.Drawing.Point(92, 111);
			this.WaistBox.Name = "WaistBox";
			this.WaistBox.Size = new System.Drawing.Size(53, 17);
			this.WaistBox.TabIndex = 0;
			this.WaistBox.Text = "Waist";
			this.WaistBox.UseVisualStyleBackColor = true;
			this.WaistBox.CheckedChanged += new System.EventHandler(this.WaistBox_CheckedChanged);
			// 
			// HeadBox
			// 
			this.HeadBox.AutoSize = true;
			this.HeadBox.Location = new System.Drawing.Point(6, 111);
			this.HeadBox.Name = "HeadBox";
			this.HeadBox.Size = new System.Drawing.Size(52, 17);
			this.HeadBox.TabIndex = 0;
			this.HeadBox.Text = "Head";
			this.HeadBox.UseVisualStyleBackColor = true;
			this.HeadBox.CheckedChanged += new System.EventHandler(this.HeadBox_CheckedChanged);
			// 
			// FeetBox
			// 
			this.FeetBox.AutoSize = true;
			this.FeetBox.Location = new System.Drawing.Point(92, 88);
			this.FeetBox.Name = "FeetBox";
			this.FeetBox.Size = new System.Drawing.Size(47, 17);
			this.FeetBox.TabIndex = 0;
			this.FeetBox.Text = "Feet";
			this.FeetBox.UseVisualStyleBackColor = true;
			this.FeetBox.CheckedChanged += new System.EventHandler(this.FeetBox_CheckedChanged);
			// 
			// WristBox
			// 
			this.WristBox.AutoSize = true;
			this.WristBox.Location = new System.Drawing.Point(6, 88);
			this.WristBox.Name = "WristBox";
			this.WristBox.Size = new System.Drawing.Size(50, 17);
			this.WristBox.TabIndex = 0;
			this.WristBox.Text = "Wrist";
			this.WristBox.UseVisualStyleBackColor = true;
			this.WristBox.CheckedChanged += new System.EventHandler(this.WristBox_CheckedChanged);
			// 
			// RingBox
			// 
			this.RingBox.AutoSize = true;
			this.RingBox.Location = new System.Drawing.Point(92, 65);
			this.RingBox.Name = "RingBox";
			this.RingBox.Size = new System.Drawing.Size(48, 17);
			this.RingBox.TabIndex = 0;
			this.RingBox.Text = "Ring";
			this.RingBox.UseVisualStyleBackColor = true;
			this.RingBox.CheckedChanged += new System.EventHandler(this.RingBox_CheckedChanged);
			// 
			// BodyBox
			// 
			this.BodyBox.AutoSize = true;
			this.BodyBox.Location = new System.Drawing.Point(92, 42);
			this.BodyBox.Name = "BodyBox";
			this.BodyBox.Size = new System.Drawing.Size(50, 17);
			this.BodyBox.TabIndex = 0;
			this.BodyBox.Text = "Body";
			this.BodyBox.UseVisualStyleBackColor = true;
			this.BodyBox.CheckedChanged += new System.EventHandler(this.BodyBox_CheckedChanged);
			// 
			// NeckBox
			// 
			this.NeckBox.AutoSize = true;
			this.NeckBox.Location = new System.Drawing.Point(6, 65);
			this.NeckBox.Name = "NeckBox";
			this.NeckBox.Size = new System.Drawing.Size(52, 17);
			this.NeckBox.TabIndex = 0;
			this.NeckBox.Text = "Neck";
			this.NeckBox.UseVisualStyleBackColor = true;
			this.NeckBox.CheckedChanged += new System.EventHandler(this.NeckBox_CheckedChanged);
			// 
			// SecondaryBox
			// 
			this.SecondaryBox.AutoSize = true;
			this.SecondaryBox.Location = new System.Drawing.Point(92, 19);
			this.SecondaryBox.Name = "SecondaryBox";
			this.SecondaryBox.Size = new System.Drawing.Size(77, 17);
			this.SecondaryBox.TabIndex = 0;
			this.SecondaryBox.Text = "Secondary";
			this.SecondaryBox.UseVisualStyleBackColor = true;
			this.SecondaryBox.CheckedChanged += new System.EventHandler(this.SecondaryBox_CheckedChanged);
			// 
			// QuiverBox
			// 
			this.QuiverBox.AutoSize = true;
			this.QuiverBox.Location = new System.Drawing.Point(6, 42);
			this.QuiverBox.Name = "QuiverBox";
			this.QuiverBox.Size = new System.Drawing.Size(57, 17);
			this.QuiverBox.TabIndex = 0;
			this.QuiverBox.Text = "Quiver";
			this.QuiverBox.UseVisualStyleBackColor = true;
			this.QuiverBox.CheckedChanged += new System.EventHandler(this.QuiverBox_CheckedChanged);
			// 
			// PrimaryBox
			// 
			this.PrimaryBox.AutoSize = true;
			this.PrimaryBox.Location = new System.Drawing.Point(6, 19);
			this.PrimaryBox.Name = "PrimaryBox";
			this.PrimaryBox.Size = new System.Drawing.Size(60, 17);
			this.PrimaryBox.TabIndex = 0;
			this.PrimaryBox.Text = "Primary";
			this.PrimaryBox.UseVisualStyleBackColor = true;
			this.PrimaryBox.CheckedChanged += new System.EventHandler(this.PrimaryBox_CheckedChanged);
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.MultiplierBox);
			this.groupBox8.Controls.Add(this.label11);
			this.groupBox8.Controls.Add(this.CriticalMaxBox);
			this.groupBox8.Controls.Add(this.label9);
			this.groupBox8.Controls.Add(this.CriticalMinBox);
			this.groupBox8.Controls.Add(this.label10);
			this.groupBox8.Location = new System.Drawing.Point(261, 341);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(202, 104);
			this.groupBox8.TabIndex = 8;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Critical :";
			// 
			// MultiplierBox
			// 
			this.MultiplierBox.Location = new System.Drawing.Point(76, 75);
			this.MultiplierBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.MultiplierBox.Name = "MultiplierBox";
			this.MultiplierBox.Size = new System.Drawing.Size(59, 20);
			this.MultiplierBox.TabIndex = 2;
			this.MultiplierBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.MultiplierBox.ValueChanged += new System.EventHandler(this.MultiplierBox_ValueChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(16, 77);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(54, 13);
			this.label11.TabIndex = 1;
			this.label11.Text = "Multiplier :";
			// 
			// CriticalMaxBox
			// 
			this.CriticalMaxBox.Location = new System.Drawing.Point(76, 49);
			this.CriticalMaxBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.CriticalMaxBox.Name = "CriticalMaxBox";
			this.CriticalMaxBox.Size = new System.Drawing.Size(59, 20);
			this.CriticalMaxBox.TabIndex = 2;
			this.CriticalMaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.CriticalMaxBox.ValueChanged += new System.EventHandler(this.CriticalMaxBox_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 51);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(57, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Maximum :";
			// 
			// CriticalMinBox
			// 
			this.CriticalMinBox.Location = new System.Drawing.Point(76, 23);
			this.CriticalMinBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.CriticalMinBox.Name = "CriticalMinBox";
			this.CriticalMinBox.Size = new System.Drawing.Size(59, 20);
			this.CriticalMinBox.TabIndex = 2;
			this.CriticalMinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.CriticalMinBox.ValueChanged += new System.EventHandler(this.CriticalMinBox_ValueChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(16, 25);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 13);
			this.label10.TabIndex = 1;
			this.label10.Text = "Minimum :";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(7, 15);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(44, 13);
			this.label15.TabIndex = 3;
			this.label15.Text = "Tileset :";
			// 
			// GLIncomingTile
			// 
			this.GLIncomingTile.BackColor = System.Drawing.Color.Black;
			this.GLIncomingTile.Location = new System.Drawing.Point(200, 289);
			this.GLIncomingTile.Name = "GLIncomingTile";
			this.GLIncomingTile.Size = new System.Drawing.Size(181, 165);
			this.GLIncomingTile.TabIndex = 2;
			this.GLIncomingTile.VSync = true;
			this.GLIncomingTile.Load += new System.EventHandler(this.GLIncomingTile_Load);
			this.GLIncomingTile.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Tiles);
			this.GLIncomingTile.Resize += new System.EventHandler(this.GLIncomingTile_Resize);
			// 
			// GLThrownTile
			// 
			this.GLThrownTile.BackColor = System.Drawing.Color.Black;
			this.GLThrownTile.Location = new System.Drawing.Point(6, 289);
			this.GLThrownTile.Name = "GLThrownTile";
			this.GLThrownTile.Size = new System.Drawing.Size(181, 165);
			this.GLThrownTile.TabIndex = 2;
			this.GLThrownTile.VSync = true;
			this.GLThrownTile.Load += new System.EventHandler(this.GLThrownTile_Load);
			this.GLThrownTile.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Tiles);
			this.GLThrownTile.Resize += new System.EventHandler(this.GLThrownTile_Resize);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(206, 265);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 13);
			this.label12.TabIndex = 1;
			this.label12.Text = "Incoming :";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 265);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(49, 13);
			this.label13.TabIndex = 1;
			this.label13.Text = "Thrown :";
			// 
			// TileSetNameBox
			// 
			this.TileSetNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TileSetNameBox.FormattingEnabled = true;
			this.TileSetNameBox.Location = new System.Drawing.Point(66, 10);
			this.TileSetNameBox.Name = "TileSetNameBox";
			this.TileSetNameBox.Size = new System.Drawing.Size(121, 21);
			this.TileSetNameBox.Sorted = true;
			this.TileSetNameBox.TabIndex = 0;
			this.TileSetNameBox.SelectedIndexChanged += new System.EventHandler(this.TileSetOnSelectedChanged);
			// 
			// IncomingTileBox
			// 
			this.IncomingTileBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.IncomingTileBox.FormattingEnabled = true;
			this.IncomingTileBox.Location = new System.Drawing.Point(264, 262);
			this.IncomingTileBox.Name = "IncomingTileBox";
			this.IncomingTileBox.Size = new System.Drawing.Size(122, 21);
			this.IncomingTileBox.TabIndex = 0;
			this.IncomingTileBox.SelectedIndexChanged += new System.EventHandler(this.IncomingTile_OnChange);
			// 
			// ThrownTileBox
			// 
			this.ThrownTileBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ThrownTileBox.FormattingEnabled = true;
			this.ThrownTileBox.Location = new System.Drawing.Point(77, 262);
			this.ThrownTileBox.Name = "ThrownTileBox";
			this.ThrownTileBox.Size = new System.Drawing.Size(110, 21);
			this.ThrownTileBox.TabIndex = 0;
			this.ThrownTileBox.SelectedIndexChanged += new System.EventHandler(this.ThrownID_OnChange);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.ThiefBox);
			this.groupBox3.Controls.Add(this.MageBox);
			this.groupBox3.Controls.Add(this.ClericBox);
			this.groupBox3.Controls.Add(this.RangerBox);
			this.groupBox3.Controls.Add(this.PaladinBox);
			this.groupBox3.Controls.Add(this.FighterBox);
			this.groupBox3.Location = new System.Drawing.Point(261, 265);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(202, 70);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Allowed professions :";
			// 
			// ThiefBox
			// 
			this.ThiefBox.AutoSize = true;
			this.ThiefBox.Location = new System.Drawing.Point(137, 42);
			this.ThiefBox.Name = "ThiefBox";
			this.ThiefBox.Size = new System.Drawing.Size(50, 17);
			this.ThiefBox.TabIndex = 0;
			this.ThiefBox.Text = "Thief";
			this.ThiefBox.UseVisualStyleBackColor = true;
			this.ThiefBox.CheckedChanged += new System.EventHandler(this.ThiefBox_CheckedChanged);
			// 
			// MageBox
			// 
			this.MageBox.AutoSize = true;
			this.MageBox.Location = new System.Drawing.Point(137, 19);
			this.MageBox.Name = "MageBox";
			this.MageBox.Size = new System.Drawing.Size(53, 17);
			this.MageBox.TabIndex = 0;
			this.MageBox.Text = "Mage";
			this.MageBox.UseVisualStyleBackColor = true;
			this.MageBox.CheckedChanged += new System.EventHandler(this.MageBox_CheckedChanged);
			// 
			// ClericBox
			// 
			this.ClericBox.AutoSize = true;
			this.ClericBox.Location = new System.Drawing.Point(70, 42);
			this.ClericBox.Name = "ClericBox";
			this.ClericBox.Size = new System.Drawing.Size(52, 17);
			this.ClericBox.TabIndex = 0;
			this.ClericBox.Text = "Cleric";
			this.ClericBox.UseVisualStyleBackColor = true;
			this.ClericBox.CheckedChanged += new System.EventHandler(this.ClericBox_CheckedChanged);
			// 
			// RangerBox
			// 
			this.RangerBox.AutoSize = true;
			this.RangerBox.Location = new System.Drawing.Point(70, 19);
			this.RangerBox.Name = "RangerBox";
			this.RangerBox.Size = new System.Drawing.Size(61, 17);
			this.RangerBox.TabIndex = 0;
			this.RangerBox.Text = "Ranger";
			this.RangerBox.UseVisualStyleBackColor = true;
			this.RangerBox.CheckedChanged += new System.EventHandler(this.RangerBox_CheckedChanged);
			// 
			// PaladinBox
			// 
			this.PaladinBox.AutoSize = true;
			this.PaladinBox.Location = new System.Drawing.Point(6, 42);
			this.PaladinBox.Name = "PaladinBox";
			this.PaladinBox.Size = new System.Drawing.Size(61, 17);
			this.PaladinBox.TabIndex = 0;
			this.PaladinBox.Text = "Paladin";
			this.PaladinBox.UseVisualStyleBackColor = true;
			this.PaladinBox.CheckedChanged += new System.EventHandler(this.PaladinBox_CheckedChanged);
			// 
			// FighterBox
			// 
			this.FighterBox.AutoSize = true;
			this.FighterBox.Location = new System.Drawing.Point(6, 19);
			this.FighterBox.Name = "FighterBox";
			this.FighterBox.Size = new System.Drawing.Size(58, 17);
			this.FighterBox.TabIndex = 0;
			this.FighterBox.Text = "Fighter";
			this.FighterBox.UseVisualStyleBackColor = true;
			this.FighterBox.CheckedChanged += new System.EventHandler(this.FighterBox_CheckedChanged);
			// 
			// InterfaceNameBox
			// 
			this.InterfaceNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InterfaceNameBox.FormattingEnabled = true;
			this.InterfaceNameBox.Location = new System.Drawing.Point(81, 40);
			this.InterfaceNameBox.Name = "InterfaceNameBox";
			this.InterfaceNameBox.Size = new System.Drawing.Size(148, 21);
			this.InterfaceNameBox.Sorted = true;
			this.InterfaceNameBox.TabIndex = 2;
			this.InterfaceNameBox.SelectedIndexChanged += new System.EventHandler(this.InterfaceNameBox_SelectedIndexChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(20, 43);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(55, 13);
			this.label17.TabIndex = 0;
			this.label17.Text = "Interface :";
			// 
			// ScriptNameBox
			// 
			this.ScriptNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ScriptNameBox.FormattingEnabled = true;
			this.ScriptNameBox.Location = new System.Drawing.Point(81, 13);
			this.ScriptNameBox.Name = "ScriptNameBox";
			this.ScriptNameBox.Size = new System.Drawing.Size(148, 21);
			this.ScriptNameBox.Sorted = true;
			this.ScriptNameBox.TabIndex = 1;
			this.ScriptNameBox.SelectedIndexChanged += new System.EventHandler(this.ScriptNameBox_SelectedIndexChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(6, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(69, 13);
			this.label16.TabIndex = 0;
			this.label16.Text = "Script name :";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.VisualTab);
			this.tabControl1.Controls.Add(this.PropertiesTab);
			this.tabControl1.Controls.Add(this.ScriptTab);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(3, 16);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(815, 626);
			this.tabControl1.TabIndex = 10;
			// 
			// VisualTab
			// 
			this.VisualTab.Controls.Add(this.label15);
			this.VisualTab.Controls.Add(this.GLGroundTile);
			this.VisualTab.Controls.Add(this.GLInventoryTile);
			this.VisualTab.Controls.Add(this.ThrownTileBox);
			this.VisualTab.Controls.Add(this.GLIncomingTile);
			this.VisualTab.Controls.Add(this.IncomingTileBox);
			this.VisualTab.Controls.Add(this.label2);
			this.VisualTab.Controls.Add(this.InventoryTileBox);
			this.VisualTab.Controls.Add(this.GLThrownTile);
			this.VisualTab.Controls.Add(this.TileSetNameBox);
			this.VisualTab.Controls.Add(this.label1);
			this.VisualTab.Controls.Add(this.label13);
			this.VisualTab.Controls.Add(this.label12);
			this.VisualTab.Controls.Add(this.GroundTileBox);
			this.VisualTab.Location = new System.Drawing.Point(4, 22);
			this.VisualTab.Name = "VisualTab";
			this.VisualTab.Padding = new System.Windows.Forms.Padding(3);
			this.VisualTab.Size = new System.Drawing.Size(807, 600);
			this.VisualTab.TabIndex = 0;
			this.VisualTab.Text = "Visuals";
			this.VisualTab.UseVisualStyleBackColor = true;
			// 
			// PropertiesTab
			// 
			this.PropertiesTab.Controls.Add(this.groupBox1);
			this.PropertiesTab.Controls.Add(this.groupBox4);
			this.PropertiesTab.Controls.Add(this.groupBox8);
			this.PropertiesTab.Controls.Add(this.groupBox5);
			this.PropertiesTab.Controls.Add(this.groupBox6);
			this.PropertiesTab.Controls.Add(this.groupBox3);
			this.PropertiesTab.Controls.Add(this.DamageBox);
			this.PropertiesTab.Location = new System.Drawing.Point(4, 22);
			this.PropertiesTab.Name = "PropertiesTab";
			this.PropertiesTab.Padding = new System.Windows.Forms.Padding(3);
			this.PropertiesTab.Size = new System.Drawing.Size(807, 600);
			this.PropertiesTab.TabIndex = 1;
			this.PropertiesTab.Text = "Properties";
			this.PropertiesTab.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.SlashBox);
			this.groupBox1.Controls.Add(this.BludgeBox);
			this.groupBox1.Controls.Add(this.PiercingBox);
			this.groupBox1.Location = new System.Drawing.Point(469, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(111, 105);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Damage type :";
			// 
			// SlashBox
			// 
			this.SlashBox.AutoSize = true;
			this.SlashBox.Location = new System.Drawing.Point(6, 73);
			this.SlashBox.Name = "SlashBox";
			this.SlashBox.Size = new System.Drawing.Size(52, 17);
			this.SlashBox.TabIndex = 0;
			this.SlashBox.Text = "Slash";
			this.SlashBox.UseVisualStyleBackColor = true;
			this.SlashBox.CheckedChanged += new System.EventHandler(this.SlashBox_CheckedChanged);
			// 
			// BludgeBox
			// 
			this.BludgeBox.AutoSize = true;
			this.BludgeBox.Location = new System.Drawing.Point(6, 50);
			this.BludgeBox.Name = "BludgeBox";
			this.BludgeBox.Size = new System.Drawing.Size(59, 17);
			this.BludgeBox.TabIndex = 0;
			this.BludgeBox.Text = "Bludge";
			this.BludgeBox.UseVisualStyleBackColor = true;
			this.BludgeBox.CheckedChanged += new System.EventHandler(this.BludgeBox_CheckedChanged);
			// 
			// PiercingBox
			// 
			this.PiercingBox.AutoSize = true;
			this.PiercingBox.Location = new System.Drawing.Point(6, 27);
			this.PiercingBox.Name = "PiercingBox";
			this.PiercingBox.Size = new System.Drawing.Size(56, 17);
			this.PiercingBox.TabIndex = 0;
			this.PiercingBox.Text = "Pierce";
			this.PiercingBox.UseVisualStyleBackColor = true;
			this.PiercingBox.CheckedChanged += new System.EventHandler(this.PiercingBox_CheckedChanged);
			// 
			// ScriptTab
			// 
			this.ScriptTab.Controls.Add(this.groupBox2);
			this.ScriptTab.Location = new System.Drawing.Point(4, 22);
			this.ScriptTab.Name = "ScriptTab";
			this.ScriptTab.Size = new System.Drawing.Size(807, 600);
			this.ScriptTab.TabIndex = 2;
			this.ScriptTab.Text = "Scripting";
			this.ScriptTab.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.InterfaceNameBox);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.ScriptNameBox);
			this.groupBox2.Location = new System.Drawing.Point(3, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(263, 135);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Interface :";
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.tabControl1);
			this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox11.Location = new System.Drawing.Point(0, 0);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(821, 645);
			this.groupBox11.TabIndex = 13;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Properties :";
			// 
			// DamageBox
			// 
			this.DamageBox.ControlText = "Damage :";
			dice1.Faces = 1;
			dice1.Modifier = 0;
			dice1.Throws = 1;
			this.DamageBox.Dice = dice1;
			this.DamageBox.Location = new System.Drawing.Point(3, 341);
			this.DamageBox.MinimumSize = new System.Drawing.Size(225, 100);
			this.DamageBox.Name = "DamageBox";
			this.DamageBox.Size = new System.Drawing.Size(252, 104);
			this.DamageBox.TabIndex = 9;
			this.DamageBox.ValueChanged += new System.EventHandler(this.DamageBox_ValueChanged);
			// 
			// ItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 645);
			this.Controls.Add(this.groupBox11);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Name = "ItemForm";
			this.TabText = "ItemForm";
			this.Text = "ItemForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
			this.Load += new System.EventHandler(this.Form_Load);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.ACBonusBox)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.RangeBox)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.WeightBox)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.SpeedBox)).EndInit();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.MultiplierBox)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.CriticalMaxBox)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.CriticalMinBox)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.VisualTab.ResumeLayout(false);
			this.VisualTab.PerformLayout();
			this.PropertiesTab.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ScriptTab.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private OpenTK.GLControl GLGroundTile;
		private OpenTK.GLControl GLInventoryTile;
		private OpenTK.GLControl GLIncomingTile;
		private OpenTK.GLControl GLThrownTile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox GroundTileBox;
		private System.Windows.Forms.ComboBox InventoryTileBox;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox DescriptionBox;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ComboBox TypeBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.CheckBox WaistBox;
		private System.Windows.Forms.CheckBox HeadBox;
		private System.Windows.Forms.CheckBox FeetBox;
		private System.Windows.Forms.CheckBox WristBox;
		private System.Windows.Forms.CheckBox RingBox;
		private System.Windows.Forms.CheckBox BodyBox;
		private System.Windows.Forms.CheckBox NeckBox;
		private System.Windows.Forms.CheckBox SecondaryBox;
		private System.Windows.Forms.CheckBox QuiverBox;
		private System.Windows.Forms.CheckBox PrimaryBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown SpeedBox;
		private System.Windows.Forms.NumericUpDown WeightBox;
		private System.Windows.Forms.Label Weight;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.NumericUpDown CriticalMaxBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown CriticalMinBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown MultiplierBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox IncomingTileBox;
		private System.Windows.Forms.ComboBox ThrownTileBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox ThiefBox;
		private System.Windows.Forms.CheckBox MageBox;
		private System.Windows.Forms.CheckBox ClericBox;
		private System.Windows.Forms.CheckBox RangerBox;
		private System.Windows.Forms.CheckBox PaladinBox;
		private System.Windows.Forms.CheckBox FighterBox;
		private System.Windows.Forms.CheckBox TwoHandedBox;
		private System.Windows.Forms.NumericUpDown ACBonusBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox TileSetNameBox;
		private System.Windows.Forms.ComboBox ScriptNameBox;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox InterfaceNameBox;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage VisualTab;
		private System.Windows.Forms.TabPage PropertiesTab;
		private System.Windows.Forms.TabPage ScriptTab;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.NumericUpDown RangeBox;
		private System.Windows.Forms.Label label3;
		private DiceForm DamageBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox UseQuiverBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox SlashBox;
		private System.Windows.Forms.CheckBox BludgeBox;
		private System.Windows.Forms.CheckBox PiercingBox;
	}
}