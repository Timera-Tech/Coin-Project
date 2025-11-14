using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Coins
    {


        public void Setup()
        {

        }

        public void Update()
        {

        }
        public void DrawCoins() 
        {
            Color Yellow = new Color(252, 229, 112);
            Color Gold = new Color(212, 175, 55);
            Draw.LineSize = 1;
            Draw.LineColor = Gold;
            Draw.FillColor = Yellow;
            Draw.Circle(Window.Size.X/ 2,15, 15);
        }
    }
}
