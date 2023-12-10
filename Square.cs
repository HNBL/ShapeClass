using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    class Square : Shape , IRotate
    {
        private double a; 
        public Square(double a)
        {
            this.a = a;
        }
        public void Rotate(double gradus) 
        {
            Console.WriteLine("Повернули Квадрат на " + Convert.ToString(gradus) + " Градусов");
        }
        override public double Perimetr()
        {
            return a * 4;
        }

        override public double Squa()
        {
            return a * 4; 
        }

         override public void Show()
        {
            Console.WriteLine("Квадрат\t = " + String.Format("{0:F3}", Squa()) +"\tP= " + String.Format("{0:F3}", Perimetr()) + "\tСторона:" + Convert.ToString(a));
        }

    }
}
