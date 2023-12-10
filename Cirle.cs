using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
     class Cirle :Shape
    {
        private double R;
        public Cirle(double R)
        {
         this.R = R;
        }
         override public double Perimetr()
        {
            return 2 * Math.PI * R;
        }

         override public double Squa()
        {
            return R * Math.PI * R;
        }

         override public void Show()
        {
         Console.WriteLine("Окружность\t = " + String.Format("{0:F3}", Squa()) + "\tP= " + String.Format("{0:F3}", Perimetr()) + "\tСторона:" + Convert.ToString(R));

        }


    }
}
