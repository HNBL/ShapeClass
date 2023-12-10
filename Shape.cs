using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeClass
{
    class Shapes
    {
        List<Shape> ShapeList = new List<Shape>();
        public void SetShape(Shape side)
        {
            ShapeList.Add(side);
        }
        public void Sort()
        {
            ShapeList.Sort();
        }
        public void Rotate(int i, double gradus)
        {
            if (i < ShapeList.Count)
            {
                if (ShapeList[i].GetType().Name == "Квадрат")
                {
                    Console.WriteLine("не поворачивается ");

                }
                else
                    if (ShapeList[i].GetType().Name == "Треугольник")
                {

                    ((Triangle)ShapeList[i]).Rotate(45);
                }
                else
                if (ShapeList[i].GetType().Name == "Квадрат")
                {

                    ((Square)ShapeList[i]).Rotate(45);
                }
            }
        }

        public void Show()
        {
            foreach (Shape Shape in ShapeList)
            {
                Shape.Show();
            }

        }





    }
}
