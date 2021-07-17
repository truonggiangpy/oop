﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    using System;
        class Rectangle
        {
            protected double length;
            protected double width;
            //haha
            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }
            public double GetArea()
            {
                return length * width;
            }
            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }
        class Tabletop : Rectangle
        {
        private double giang;
        public Tabletop(double l, double w) : base(l, w)
            {
            giang = 2;
        }

            public double GetCost()
            {
                return GetArea() * 70;
            }

            public void Display()
            {
               base.Display();
                Console.WriteLine("Cost: {0}", GetCost());
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Tabletop tabletop = new Tabletop(4.5, 7.5);
            tabletop.Display();
            Console.ReadLine();
        }
    }
}
