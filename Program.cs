using System;




namespace ShapeClass
{

    class Program
    {

     
        static void Main(string[] args) 
        {
        Shapes Shapes = new Shapes();

            Shapes.SetShape(new Triangle(4, 5.1, 1.2));
            Shapes.SetShape(new Triangle(6));
            Shapes.SetShape(new Triangle(2, 1.2, 4));
            Shapes.SetShape(new Triangle(3,5,6));
            Shapes.SetShape(new Triangle(2,3,4));
            Shapes.SetShape(new Triangle(0.2));
            Shapes.SetShape(new Triangle(1));
            Shapes.SetShape(new Cirle(0.2));
            Shapes.SetShape(new Cirle(4));
            Shapes.SetShape(new Cirle(6));
            Shapes.SetShape(new Cirle(1.5));
            Shapes.SetShape(new Square(0.9));
            Shapes.SetShape(new Square(1.2));
            Shapes.SetShape(new Square(3));
            Shapes.SetShape(new Square(5));
            Shapes.Sort ();
            Shapes.Show ();
            Shapes.Rotate(2, 4);

           Console.ReadLine (); 



        }




    }

}
