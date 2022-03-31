using System;

namespace SandBox
{
    public class Figure
    {
        public virtual double Square()
        {
            return 0;
        }
    }

    public class Treangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        /// <summary>
        /// Создание треугольника
        /// </summary>
        /// <param name="a">Катет</param>
        /// <param name="b">Катет</param>
        /// <param name="c">Гипотинуза</param>
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

        public bool RightTriangle()
        {
            if (Math.Abs(Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) == 0)
                return true;
            return false;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Treangle treangle = new Treangle(6, 8, 10);
            Console.WriteLine(treangle.Square());
            Console.WriteLine(treangle.RightTriangle());
        }
    }
}