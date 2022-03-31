using System;

namespace SandBox
{
    public class Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public virtual double Square()
        {
            return 0;
        }
    }

    public class Treangle : Figure
    {


        public Treangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public override double Square()
        {
            var p = (A + B + C) / 2;
            if (p == 0)
                return 0;
            var s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            if (double.IsNaN(s))
                return 0;
            return s;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Treangle treangle = new Treangle(7, 2, 4);
            Console.WriteLine(treangle.Square());
        }
    }
}