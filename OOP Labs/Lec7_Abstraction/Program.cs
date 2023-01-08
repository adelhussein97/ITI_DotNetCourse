using System;

namespace Lec7_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double dim = 0, width = 0;


            Console.WriteLine("Please Enter The Dimension of Shape : ");
            dim = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter The Dimension 2 of Shape : ");
            width = Convert.ToDouble(Console.ReadLine());

            Square square = new Square(dim);
            Rectangle rectangle = new Rectangle(dim, width);
            Circle Circle = new Circle(dim);

            Cls_Shapes [] shapes=new Cls_Shapes[3];
            shapes[0] = square;
            shapes[1] = rectangle;
            shapes[2] = Circle;

            Pictures pictures = new Pictures(shapes);
            Console.WriteLine($"The Total Area of Picture Shapes = {pictures.GetTotalArea()}");

            Console.ReadKey();

        }
    }
}
