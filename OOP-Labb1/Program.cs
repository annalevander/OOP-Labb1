namespace OOP_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //skapar ett objekt av Circle klassen och beräknar area
            Circle circle1 = new Circle(5);
            double area1 = circle1.GetArea();
            Console.WriteLine($"Cirkelns area är {area1}\n");

            Circle circle2 = new Circle(6);
            double area2 = circle2.GetArea();
            Console.WriteLine($"Cirkelns area är {area2}\n");

            //skapar ett objekt av triangle klassen och beräknar area
            Triangle triangle1 = new Triangle(3, 5);
            double areaOfTriangle1 = triangle1.AreaOfTriangle();
            Console.WriteLine($"Triangelns area är {areaOfTriangle1}\n");

            Triangle triangle2 = new Triangle(5, 7);
            double areaOfTriangle2 = triangle2.AreaOfTriangle();
            Console.WriteLine($"Triangelns area är {areaOfTriangle2}");
        }
    }
}
