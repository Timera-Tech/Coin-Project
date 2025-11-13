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

        public void Setup()
        {

        }

        public void Update()
        {

    
           
        }

        void DrawCrate(int x, int y, Color crateopen)
        {
            Color Brown = new Color(168, 112, 78);
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Brown;

            Draw.Rectangle(new Vector2(x, y), new Vector2(100, 100));

        }
    }

}
