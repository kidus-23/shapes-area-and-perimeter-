using Shape;

int c;

Console.WriteLine("Which shape do u want to do the area and perimeter of: ");
Console.WriteLine("1.Circle, 2.Square, 3.Triangle");
c = Convert.ToInt32(Console.Read());

if (c == 1)
{
    Console.WriteLine("Enter the radius: ");
    Circle c1 = new Circle();
    c1.r = Console.Read();
}
else if (c == 2)
{
    Console.WriteLine("Enter the Length and the Width: ");
    Square c2 = new Square();
    c2.l = Console.Read();
    c2.w = Console.Read();
}
else if (c == 3)
{
  
    Console.WriteLine("Enter the 3 sides: ");
    Triangle c3 = new Triangle();
    c3.s1 = Console.Read();
    c3.s2 = Console.Read();
    c3.s3 = Console.Read();
}
