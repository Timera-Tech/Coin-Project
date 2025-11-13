using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Barrel
    {
        Vector2 position;
        public void Setup()
        {
            position = new Vector2(150, 100);
        }

        public void Update()
        {
 
            DrawBarrel();
           
        }

        void DrawBarrel()
        {
            ///Draw barrel
            
            Color barrelbrown = new Color(168, 112, 78);
            Draw.FillColor = (barrelbrown);
            Draw.LineColor = barrelbrown;
            Draw.LineSize = 10.0f;

            ///barrel position
            //Vector2 rectanglePosition = new Vector2(150, 100);
            Vector2 rectangleSize = new Vector2(100, 100);
            Draw.Rectangle(position, new Vector2(150, 100));
        }
    }

}
