namespace OOP_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            double area1 = circle1.GetArea();
            Console.WriteLine($"Cirkelns area är {area1}");

            Circle circle2 = new Circle(6);
            double area2 = circle2.GetArea();
            Console.WriteLine($"Cirkelns area är {area2}");
        }
    }
}
