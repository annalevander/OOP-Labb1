namespace OOP_Labb1
{
    public class Circle
    {
        float _pi = 3.141f;
        int Radius;
        
        public Circle(int radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            double Area = Radius * Radius * _pi;
            return Area;
        }
    }
}
