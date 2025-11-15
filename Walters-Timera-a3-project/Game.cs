// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        public Coins coins;
        public Crate crate;
        public Clouds clouds;
        public Bombs bombs;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Coin Collector");
            Window.SetSize(300, 800);
            Window.TargetFPS = 60;

            crate = new Crate();
            coins = new Coins();

           
    

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            ///Colors and background goes here
            Color Brown = new Color(168, 112, 78);
            Color Lightblue = new Color(135, 206, 235);
            Color Grassgreen = new Color(72, 111, 56);
            Color Yellow = new Color(252, 229, 112);
            Color Gold = new Color(212, 175, 55);

            Window.ClearBackground(Lightblue);

;
            ///Drawing the Land
            Draw.LineSize = 0;
            Draw.FillColor = (Grassgreen);
            Draw.Rectangle(new Vector2(0,750), new Vector2(300, 50));
           
            ///Call the coins
            coins.DrawCoins();
      
            ///Call the crate
            crate.Update();
            crate.DrawCrate();

            ///Call Clouds (FAILED)
            clouds = new Clouds();
            clouds.DrawClouds(0, 1, Color.White);

            ///Call Bombs
            bombs = new Bombs();
            bombs.DrawBombs();

            ///Counter (FAIL)
            int moneycounter = 0;
            Text.Draw("Coins: " + moneycounter, new Vector2(1, 1));
            if (moneycounter == 0)
                moneycounter++;

        }

        
    }

}
