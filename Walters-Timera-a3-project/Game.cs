// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Coin Collector");
            Window.SetSize(300, 800);
            Window.TargetFPS = 60;
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            ///Colors and background goes here
            Color Lightblue = new Color(135, 206, 235);
            Color Grassgreen = new Color(72, 111, 56);
            Color Yellow = new Color(252, 229, 112);
            Color Gold = new Color(212, 175, 55);

            Window.ClearBackground(Lightblue);

            ///Drawing the Land
            Draw.LineSize = 0;
            Draw.FillColor = (Grassgreen);
            Draw.Rectangle(new Vector2(0,750), new Vector2(300, 50));
            
        }

        
    }

}
