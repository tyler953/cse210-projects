namespace Develop04
{
    public class Breathing : Activity
    {
        public Breathing()
        {
            _message = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
            _type = "Breathing";
        }

        public void RunBreathing()
        {
            StartSequence(_type, _message);
            DateTime currentTime = DateTime.Now;
            DateTime endTime = currentTime.AddSeconds(GetTime());
            while (currentTime < endTime)
            {
                Console.Write("\n\nBreathe in...4");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("3");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("2");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("1");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("0");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("\nNow breathe out...6");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("5");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("4");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("3");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("2");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("1");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("0");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                currentTime = DateTime.Now;
            }
            EndSequence(_type);
        }
    }
}