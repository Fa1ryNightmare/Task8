using System;

namespace Task8
{
    class Trapezium
    {
        //a < b - основания, c и d - боковые стороны трапеции
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public bool IsExist()
        {
            if (A < B && A != 0 && B != 0 && C != 0 && D != 0 && S() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Формула для нахождения площади трапеции через четыре стороны
        public double S()
        {
            return ((A + B) / 4 * (B - A)) * Math.Sqrt((A + C + D - B) * (A + D - B - C) * (A + C - B - D) * (B + C + D - A));
        }

        public double P()
        {
            return A + B + C + D;
        }
    }
    class Program
    {
        static void Main()
        {
            Trapezium trp = new Trapezium();

            Console.Write("Введите длину стороны a: ");
            trp.A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны b: ");
            trp.B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны c: ");
            trp.C = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны d: ");
            trp.D = Convert.ToDouble(Console.ReadLine());

            if (trp.IsExist())
            {
                Console.WriteLine($"Площадь трапеции: {trp.S()}");
                Console.WriteLine($"Периметр трапеции: {trp.P()}");
            }
            else
            {
                Console.WriteLine("Трапеция не существует");
            }
        }
    }
}
