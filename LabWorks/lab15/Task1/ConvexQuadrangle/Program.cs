﻿using System;



namespace Test
{
    public class ConvexQuadrangle : ISides, ICoordinates
    {
        public double a;
        public double b;
        public double c;
        public double d;

        public int x1;
        public int x2;
        public int x3;
        public int x4;
        public int y1;
        public int y2;
        public int y3;
        public int y4;

        public int Sides { get; set; }
        public int Coordinates { get; set; }

        public void AssignmentSides()
        {
            Console.WriteLine($"Задано чотирикутник зi сторонами A={a}, B={b}, C={c}, D={d}");

        }

        public void AssignmentCoordinates()
        {
            Console.WriteLine($"Задано чотирикутник з координатами A({x1},{y1}), B({x2},{y2}), C({x3},{y3}), D({x4},{y4})");
            a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            c = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            d = Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));
        }

        public double Square()
        {
            double p = (a + b + c + d) / 2;
            double square = Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d));
            return square;
        }

        public double Perimetr()
        {
            double perimetr = a + b + c + d;
            return perimetr;
        }

        public void TypeOfQuadrangle()
        {
            double diagonal1 = Math.Sqrt(a * a + b * b);
            double diagonal2 = Math.Sqrt(c * c + d * d);
            double halofd1 = diagonal1 / 2;
            double halfofd2 = diagonal2 / 2;
            double cos_a = (halofd1 * halofd1 + halfofd2 * halfofd2 - a) / (2 * halofd1 * halfofd2);
            double cos_b = (halofd1 * halofd1 + halfofd2 * halfofd2 - b) / (2 * halofd1 * halfofd2);
            double cos_c = (halofd1 * halofd1 + halfofd2 * halfofd2 - c) / (2 * halofd1 * halfofd2);
            double height = Math.Sqrt(a * a - ((d - b) * (d - b) + a * a - c * c) / 2 * (d - b) * ((d - b) * (d - b) + a * a - c * c) / 2 * (d - b));
            double sin_a = Math.Sqrt(1 - cos_a * cos_a);
            if (a == b && a == c && a == d && diagonal1 == diagonal2)
            {
                Console.WriteLine("Це квадрат! (але одночасно i прямокутник i ромб)");
            }
            else if ((a == c && b == d) & diagonal1 == diagonal2)
            {
                Console.WriteLine("Це прямокутник!");
            }
            else if ((a == c && a == c && a == d) & cos_a == cos_b && cos_a == cos_c)
            {
                Console.WriteLine("Це ромб! (але одночасно i паралелограм)");
            }
            else if ((a == c && b == d) & diagonal1 != diagonal2)
            {
                Console.WriteLine("Це паралелограм!");
            }
            else if ((a == c && b != d || a == b && c != d || a == d && b != c || b == c && a != d || b == d && a != c || d == c && a != b ||
                    a != c && b != d || a != b && c != d || a != d && b != c || b != c && a != d || b != d && a != c || d != c && a != b) & height == c * sin_a)
            {
                Console.WriteLine("Це трапецiя!");

            }
            else
            {
                Console.WriteLine("Довiльний чотирикутник або взагалi не чотирикутник..");
            }
        }

    }


}