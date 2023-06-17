using System;

namespace Develop04
{
    class Program
    {
        static void Main()
        {
            Menu menu = new Menu();
            while (true)
            {
                menu.Display();
                if (menu.GetSelection() == 1)
                {
                    Breathing breathing = new Breathing();
                    breathing.RunBreathing();
                } else if (menu.GetSelection() == 2)
                {
                    Reflection reflection = new Reflection();
                    reflection.RunReflection();
                } else if (menu.GetSelection() == 3)
                {
                    Listing listing = new Listing();
                    listing.RunListing();
                } else if (menu.GetSelection() == 4)
                {
                    break;
                }
            }
        }
    }
}