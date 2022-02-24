using System;

namespace AbsFig
{
   public abstract class Frame
    {
        public double Height, Radius, Width;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }
    public class circle:Frame
    {       
        public circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }
    public class Tringel:Frame
    {
        public Tringel(double Height,double Width)
        {
            this.Height = Height; this.Width = Width;
        }
        public override double GetArea()
        {
            return 0.5 * Height * Width;
        }
    }
    class TestFrame
    {
        static void Main()
        {
            circle c = new circle(77.9);
            Console.WriteLine("Area of circle:" + c.GetArea());
            Tringel t = new Tringel(32,32);
            Console.WriteLine("area of Tringel:" + t.GetArea());
        }
    }
}
   