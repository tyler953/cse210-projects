namespace Develop04
{
    public class Activity
    {
        int _time;
        protected string _type;
        protected string _message;

        public int GetTime()
        {
            return this._time;
        }

        public void SetTime(int time)
        {
            this._time = time;
        }

        public void Animation()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.Write("\\");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("|");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("|");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }

        public void StartSequence(string activity, string message)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {activity} Activity.\n");
            Console.WriteLine(message);
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            int time = int.Parse(Console.ReadLine());
            SetTime(time);
            Console.Clear();
            Console.WriteLine("Get ready...");
            Animation();
        }

        public void EndSequence(string activity)
        {
            Console.WriteLine("\n\nWell done!!");
            Animation();
            Console.WriteLine($"You have completed another {this._time} seconds of the {activity} Activity.");
            Animation();
        }
    }
}