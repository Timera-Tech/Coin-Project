using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
 public class Clouds
    {
        public Vector2 position;

        float xSpeed = 0.0f;
        float r1;
        float r2;
        float r3;

        Vector2 originalPosition;
        public void Setup(Vector2 _position)
        {
            xSpeed = Random.Float(5.0f, 15.0f);
            r1 = Random.Float(-40, 40);
            r2 = Random.Float(10, 60);
            r3 = Random.Float(70, 120);

            position = _position;
            originalPosition = _position;
        }

        public void DrawClouds(int x, int speed, Color cloudColor)
        {
            position.X += xSpeed * Time.DeltaTime;
            position.Y = MathF.Sign(r1) * 10.0f * MathF.Sin(0.1f * Time.SecondsElapsed) + originalPosition.Y;
            if (position.X > Window.Size.X * 200.0f) position.X = -200;

            Draw.LineSize = 0;
            Draw.FillColor = new Color("#FAFAFAEE");
            Draw.Ellipse(position, new Vector2(200, 20 + r2));

            Draw.Ellipse(position + new Vector2(r1, +40), new Vector2(r3, 30));
            Draw.Ellipse(position + new Vector2(r1, +40), new Vector2(120, r3));
        }

    }
}