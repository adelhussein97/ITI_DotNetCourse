
using Lab6_InheritanceClass;


#region Assignment 1
double dim = 0, width = 0;


Console.WriteLine("Please Enter The Dimension of Shape : ");
dim = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter The Dimension 2 of Shape : ");
width = Convert.ToDouble(Console.ReadLine());

Cls_Shape shape = new Cls_Shape(dim);
Cls_Square square = new Cls_Square(dim);
Cls_Rectangle rectangle = new Cls_Rectangle(dim, width);
Cls_Circle Circle = new Cls_Circle(dim);

Console.WriteLine($"The Area of Square is : {square.CalcArea()}");
Console.WriteLine($"The Area of Rectangle is : {rectangle.CalcArea()}");
Console.WriteLine($"The Area of Circle is : {Circle.CalcArea()}");

#endregion

#region Assignment 2 Picture

Cls_Picture picture = new Cls_Picture();


#region Association Relation

Console.WriteLine($"The Total Area of Picture Circle is : {picture.Get_AreaCircle()}");
#endregion

#region Aggreagation Relation
Cls_Square s1 = new Cls_Square(5);
Cls_Rectangle r1 = new Cls_Rectangle(6,3);

picture.Square_Property = s1;
picture.RectProperty = r1;

Console.WriteLine($"The Total Area of Picture is : {picture.Get_TotalArea(s1,r1)}"); 
#endregion


#endregion

Console.ReadKey();



