namespace Develop04
{
    public class Listing : Activity
    {
        List<string> prompts = new List<string>
        {
            "Think of a time when you felt the Holy Ghost guiding you.",
            "Recall a moment this month when you felt a spiritual impression.",
            "Consider an instance when you received personal revelation recently.",
            "Reflect on a time when you experienced a tender mercy in your life.",
            "When have you felt the Holy Ghost this month?",
            "Share a spiritual experience that touched your heart in the past few weeks.",
            "Think about a time when you received comfort through the Holy Ghost.",
            "Describe a moment when you felt a deep sense of peace and assurance.",
            "Reflect on an instance when the Holy Ghost helped you make a decision.",
            "How have you seen the hand of God working in your life recently?"
        };

        private List<string> responses = new List<string> {};
        public Listing()
        {
            _message = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            _type = "Listing";
        }

        public void RunListing()
        {
            StartSequence(_type, _message);
            Random random = new Random();
            Console.WriteLine("\nList as many responses as you can to the following prompt:");
            Console.WriteLine($" --- {prompts[random.Next(0,prompts.Count)]} ---");
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
            Console.WriteLine();
            DateTime currentTime = DateTime.Now;
            DateTime endTime = currentTime.AddSeconds(GetTime());
            while (currentTime < endTime)
            {
                Console.Write("> ");
                responses.Add(Console.ReadLine());
                currentTime = DateTime.Now;
            }
            Console.WriteLine($"You listed {responses.Count} items!");
            EndSequence(_type);
        }
    }
}