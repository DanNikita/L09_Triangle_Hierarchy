using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    //public struct Sides
    //{
    //    public int Side_a;
    //    public int Side_B;
    //    public int Side_C;
    //}
    static void Main(string[] args)
    {
        Triangle Tr = new Triangle(3, 5, 7); //create class example
        Triangle Tr2 = new Triangle(4, 6, 9);
        Rectangle Rc = new Rectangle(2, 4);
        Circle Cr = new Circle(4);
        //Console.Write("Enter three sides, a:");
        //Tr.a = int.Parse(Console.ReadLine());
        //Console.Write("b:");
        //Tr.b = int.Parse(Console.ReadLine());
        //Console.Write("c:");
        //Tr.c = int.Parse(Console.ReadLine());
        ////Triangle.Print(Tr);
        //Triangle Tr2 = new Triangle();
        ////Tr2.SetSides(2, 4, 7);
        Console.WriteLine(Tr.ToString());
        Console.WriteLine(Tr2.ToString());
        Console.WriteLine(Rc.ToString());
        Console.WriteLine(Cr.ToString());
        
    }
}

interface Irotation // Interface that show that class can rotate
{
    public void Rotate();
}
abstract class Shape // Shape is an abstract class, that contains common methods for rectangle,triangle,circle
{

    public abstract double Perimeter();
    

    public abstract double Square();

}
class Rectangle : Shape, Irotation
{
    private int a, b;
    public Rectangle(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public override double Perimeter()
    {
       return 2 * a + 2 * b;
    }
    public override double  Square()
    {
       return a * b;
    }
    void Irotation.Rotate() => Console.WriteLine("The figure has been rotated");
    public override string ToString() => $"Rectangle with sides {a},{b} has Square {Square()}:";
}
class Triangle: Shape, Irotation
{

    private int a,b,c;
    public Triangle(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    
    //public bool Check() //Checking sides
    //{
    //    Console.WriteLine("Entering method to check sides");
    //    //if (side1 != 0 & side2 != 0 & side3 != 0)
    //    //    return true;
    //    //else
    //    //    return false;
    //    if (a != 0 & b != 0 & c != 0)
    //        return true;
    //    else
    //        return false;
    //}
    public override double Perimeter() //Calculating perimeter
    {
        int sum = a + b + c;
        return sum;
    }
    public override double Square() //Calculating square
    {
        double per = this.Perimeter();
        double s = Math.Sqrt(per * (per - a) * (per - b) * (per - c));
        return s;
    }
    void Irotation.Rotate() => Console.WriteLine("The figure has been rotated");
    public override string ToString()
    {
        return String.Format("Triangle with sides {0},{1},{2}, Perimeter {3}", a, b, c, this.Perimeter());
    }
}
class Circle : Shape
{
    private int r;
    public Circle(int r)
    {
        this.r = r;
    }
    public override double Perimeter()
    {
        return 2 * Math.PI * r;
    }
    public override double Square()
    {
        return Math.PI * r;
    }
    public override string ToString() => $"Circle with radius {r} has Square {Square()}:";
}
