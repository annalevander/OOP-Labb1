namespace OOP_Labb1
{
    public class Circle
    {
        //fält för pi och radius
        float _pi = 3.141f;
        int Radius;
        
        //skapar en constructor som sätter radius
        public Circle(int radius)
        {
            Radius = radius;
        }

        //skapar en metod för att räkna ut arean av en cirkel
        public double GetArea()
        {
            double Area = Radius * Radius * _pi;
            return Area;
        }
    }
}
