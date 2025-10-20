namespace OOP_Labb1
{
    public class Triangle
    {
        //fält för bas och höjd 
        double Base;
        double Height;

        //skapar en constructor som sätter bas och höjd
        public Triangle (int bas, int height)
        {
            Base = bas;
            Height = height;
        }

        //skapar en metod för att räkna ut arean av en triangel
        public double AreaOfTriangle()
        {
            double AreaTriangle = Base * Height / 2;
            return AreaTriangle;
        }
    }
}
