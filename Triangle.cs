using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    class Triangle : Shape, IRotate
    {

        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public Triangle(double a)
        {
            this.a = a;
            this.b = a;
            this.c = a;


        }
        public void Rotate(double gradus)
        {
            Console.WriteLine("Повернули треугольник  на " + Convert.ToString(gradus) + " Градусов");
        }

        override public void Show()
        {

            Console.WriteLine("Треугольник\t = " + String.Format("{0:F3}", Squa()) + "\tP = " + String.Format("{0:F3}", Perimetr()) + "\tСтороны:" + Convert.ToString(a) + "\t" + Convert.ToString(b) + "\t" + Convert.ToString(c));
        }

        private static bool TryangleChek(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c || a + c > b || b + c > a)
                {
                    return true;
                }
                else return false;
            }
            else return false;



        }
         override public double Perimetr()
        {
            return a + b + c;

        }
        override public double Squa()
        {
            if (TryangleChek(a, b, c))
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            }
            else return -1;

        }

    }
}