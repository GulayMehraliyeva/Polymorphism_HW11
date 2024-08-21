using Polymorphism___Homework11;
string n = Console.ReadLine();
switch(n)
{
    case "1":
        Console.WriteLine("Enter side length of the square:");
        int side = int.Parse(Console.ReadLine());
        Square square = new Square(side);
        int areaOfSquare = square.CalcArea();
        Console.WriteLine(areaOfSquare);
        break;
    case "2":
        Console.WriteLine("Enter width of the rectangle:");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter length of the rectangle:");
        int length = int.Parse(Console.ReadLine());
        Rectangular rectangular = new Rectangular(width, length);
        int areaOfRectangular = rectangular.CalcArea();
        Console.WriteLine(areaOfRectangular);
        break;

    case "0":
        break;

    default:
        Console.WriteLine("Please try again.");
        break;
}

