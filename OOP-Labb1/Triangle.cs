namespace OOP_Labb1
{
    public class Triangle
    {
        double Base;
        double Height;

        public Triangle (int bas, int height)
        {
            Base = bas;
            Height = height;
        }
        public double AreaOfTriangle()
        {
            double AreaTriangle = Base * Height / 2;
            return AreaTriangle;
        }
    }
}
