using System;

namespace Figure
{
    public abstract class Figure
    {
        public virtual double Square()
        {
            return 0;
        }
        public virtual bool IsCorrectRectangle()
        {
            return false;
        }
    }

    public class Circle : Figure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            this._radius = radius;
            if (this._radius<= 0)
            {
                throw new InvalidCastException
                    ("Радиус должен быть больше 0");
            }
        }

        public override double Square()
        {
            var s = Math.PI * _radius;
            return s;
        }
    }
    
    public class Triangle : Figure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        /// <summary>
        /// Создание треугольника
        /// </summary>
        /// <param name="a">Катет</param>
        /// <param name="b">Катет</param>
        /// <param name="c">Гипотинуза</param>
        public Triangle(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            if (this._a <= 0 || this._b <= 0 || this._c <= 0)
            {
                throw new InvalidCastException
                    ("Стороны треугольника должны быть больше 0");
            }
        }

        public override double Square()
        {
            var p = (_a + _b + _c) / 2;
            if (p == 0)
                return 0;
            var s = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
            if (double.IsNaN(s))
                return 0;
            return s;
        }

        public override bool IsCorrectRectangle()
        {
            return Math.Abs(Math.Pow(_a, 2) + Math.Pow(_b, 2) - Math.Pow(_c, 2)) == 0;
        }

        private static void Main(string[] args)
        {
            Triangle triangle = new Triangle(7, 8, 10);
            Console.WriteLine(triangle.Square());
            Console.WriteLine(triangle.IsCorrectRectangle());

            Circle circle = new Circle(5);
            Console.WriteLine(circle.Square());
        }
    }
}