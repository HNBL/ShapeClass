using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    interface IRotate
    {

        void Rotate(double gradus); 
    }

    abstract class Shape : IComparable
    {
        abstract public double Squa();
         abstract public double Perimetr();
        abstract public void Show();
        public int CompareTo(object obj)
        {
            Shape it =(Shape)obj;
            if (this.Squa() == it.Squa()) return 0;
            else if (this.Squa() > it.Squa()) return 1;
            else return -1;
        }

    }

}
