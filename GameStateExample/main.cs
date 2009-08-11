﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Graphic;
using ArcEngine.Input;
using ArcEngine.ScreenManager;
using ArcEngine.Asset;


namespace GameStateExample
{
	class main : Game
	{
		/// <summary>
		/// Main entry point.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			using (main game = new main())
				game.Run();
		}


		/// <summary>
		/// Constructor
		/// </summary>
		public main()
		{
			Device = new OpenGLRender();
			Device.ClearColor = Color.CornflowerBlue;
			Window.Size = new Size(1024, 768);

			GSM = new ScreenManager(this);
			GSM.AddScreen(new BackgroundScreen());
			GSM.AddScreen(new MainScreen());

		}



		#region Initialization

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  
		/// </summary>
		protected override void Initialize()
		{

			// Load a bank
			ResourceManager.LoadBank("data/data.bnk");

			// Initialize the Game Screen Manager
			GSM.Initialize();
		}


		/// <summary>
		/// Called when graphics resources need to be loaded.
		/// </summary>
		protected override void LoadContent()
		{
			GSM.LoadContent();

			GSM.Font = new TTFFont(Device);
			((TTFFont)GSM.Font).LoadFromTTF("browa.ttf", 25, FontStyle.Regular);
		}


		/// <summary>
		/// Called when graphics resources need to be unloaded.
		/// </summary>
		protected override void UnloadContent()
		{
			GSM.UnloadContent();
		}


		#endregion


		#region Game logic


		/// <summary>
		/// Called when the game determines it is time to draw a frame.
		/// </summary>
		/// <param name="device">Rendering device</param>
		protected override void Draw(VideoRender device)
		{
			device.ClearBuffers();

			GSM.Draw(device);


			if (Keyboard.IsNewKeyPress(Keys.Space))
				device.Rectangle(new Rectangle(10, 10, 100, 100), true);

		}



		/// <summary>
		/// Called when the game has determined that game logic needs to be processed.
		/// </summary>
		/// <param name="gameTime">The time passed since the last update.</param>
		protected override void Update(GameTime gameTime)
		{
			GSM.Update(gameTime);
		}


		
		#endregion


		#region Properties


		/// <summary>
		/// Game state manager
		/// </summary>
		ScreenManager GSM;


		#endregion
	}
}
