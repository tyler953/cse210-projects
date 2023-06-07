using System;

namespace Learning04
{
    class Program
    {
        static void Main()
        {
            MathAssignment assignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine($"{assignment.GetSummary()}");
            Console.WriteLine($"{assignment.GetHomeworkList()}");
            WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine($"{writing.GetSummary()}");
            Console.WriteLine($"{writing.GetWritingInformation()}");
        }
    }
}