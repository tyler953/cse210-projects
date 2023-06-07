using System;

namespace Learning03
{
class Program
    {
        static void Main()
        {
            Fraction one = new Fraction();

            Fraction wholeNumber = new Fraction(5);

            Fraction fraction = new Fraction(3, 4);

            Fraction test = new Fraction(1, 3);

            Console.WriteLine($"{one.GetFractionString()}\n{one.GetDecimalValue()}");
            Console.WriteLine($"{wholeNumber.GetFractionString()}\n{wholeNumber.GetDecimalValue()}");
            Console.WriteLine($"{fraction.GetFractionString()}\n{fraction.GetDecimalValue()}");
            Console.WriteLine($"{test.GetFractionString()}\n{test.GetDecimalValue()}");
        }
    }
}