using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Bombs
    {
        public void Setup()
        {

        }

        public void Update()
        {

        }
        public void DrawBombs()
        {

            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Black;
            Draw.Circle(Window.Size.X / 2, 200, 25);

        }
    }
}
