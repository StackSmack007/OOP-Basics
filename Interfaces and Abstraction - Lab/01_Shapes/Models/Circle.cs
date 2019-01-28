﻿using Shapes.Contracts;
using System;

namespace Shapes.Models
{
    public class Circle : IDrawable
    {
        private int radius;
        private const char symbol = '*';
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            double rIn = radius - 0.4;
            double rOut = radius + 0.4;

            for (double y = radius; y >=-radius; --y)
            {
                for (double x = -radius; x < rOut; x+=0.5)
                {
                    double value = x * x + y * y;
                    if (value>=rIn*rIn&&value<=rOut*rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}