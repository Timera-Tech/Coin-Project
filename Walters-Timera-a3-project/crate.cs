using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Crate
    {
        public Vector2 position;
        public Vector2 size;

        public Crate()
        {
            ///Mouse controls here
            position = Input.GetMousePosition();
            size = new Vector2(80, 40);
        }

        public void Update()
        {
            position = Input.GetMousePosition();
            Barrier();
        }
        /// <summary>
        /// Crate wont exeed the window

        public void Barrier()
        {
            if (position.X < 0) 
                position.X = 0; 

            if (position.Y < 0)
                position.Y = 0;

            if (position.X + size.X > Window.Width)
                position.X = Window.Width - size.X;

            if (position.Y + size.Y > Window.Height)
                position.Y = Window.Height - size.Y;
        }
        public void DrawCrate()
        {
            ///Crate is drawn here
            Color Brown = new Color(168, 112, 78);
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Brown;

            Draw.Rectangle(position, size);
           
        }

    }

}
