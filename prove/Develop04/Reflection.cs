namespace Develop04
{
    public class Reflection : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you did something really difficult.",
            "Recall a moment when you overcame a significant challenge.",
            "Consider a situation where you demonstrated resilience.",
            "Reflect on a time when you achieved a personal goal."
        };

        private List<string> _questions = new List<string>
        {
            "How did you feel when it was complete?",
            "What lessons did you learn from that experience?",
            "How did overcoming the challenge impact your confidence?",
            "In what ways has that event influenced your life?",
            "What obstacles did you encounter along the way?",
            "How did you overcome self-doubt during that experience?",
            "What strengths or skills did you discover about yourself?",
            "In what ways did that achievement impact your personal growth?",
            "How did the support of others contribute to your success?",
            "What did you learn about your perseverance and determination?",
            "Did you face any setbacks? How did you handle them?",
            "What strategies or approaches did you use to stay motivated?",
            "What advice would you give to someone facing a similar challenge?",
            "How has that achievement influenced your future goals and aspirations?"
        };

        public Reflection()
        {
            _message = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            _type = "Reflection";
        }

        public void RunReflection()
        {
            StartSequence(_type, _message);
            Random random = new Random();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"\n --- {_prompts[random.Next(0, _prompts.Count)]} ---");
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: 5");
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
            Console.Clear();
            DateTime currentTime = DateTime.Now;
            DateTime endTime = currentTime.AddSeconds(GetTime());
            while (currentTime < endTime)
            {
                Console.Write($"> {_questions[random.Next(0, _questions.Count)]} ");
                Animation();
                Animation();
                Console.WriteLine();
                currentTime = DateTime.Now;
            }
            EndSequence(_type);
        }
    }
}