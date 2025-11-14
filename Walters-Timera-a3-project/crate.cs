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

        public void DrawCrate()
        {
            Color Brown = new Color(168, 112, 78);
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Brown;

            Vector2 rectanglePosition = Input.GetMousePosition();
            Draw.Rectangle(rectanglePosition, new Vector2(80, 40));

        }
    }

}
