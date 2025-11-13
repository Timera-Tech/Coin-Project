using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Clouds
    {
        Vector2 position;
        Vector2 velocity;
        public void Setup()
        {
            position = new Vector2(100, 50);
            velocity = Random.Vector2() * 150.0f;
        }

        public void Update()
        {
            MoveClouds();
            DrawClouds();
        }

        void MoveClouds()
        {
            position += velocity * Time.DeltaTime;
        }
        void DrawClouds()
        {
            Draw.FillColor = Color.White;
            Draw.Ellipse(position, new Vector2(50, 15));

            Draw.FillColor = Color.White;
            Draw.Ellipse(position, new Vector2(70, 10));

        }

    }
}
