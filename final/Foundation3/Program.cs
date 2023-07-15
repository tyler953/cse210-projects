using System;

namespace Foundation3
{
    class Program
    {
        static void Main()
        {
            Address address = new Address("123 samplestreet", "Rexburg", "Idaho", "USA");
            Lecture lecture = new Lecture("Devotional", "Come hear the Prophet Speak!", "10-10-2023", "11:15 AM", address, "President Russel M. Nelson", 2000);
            Reception reception = new Reception("Wedding", "Congratulations!", "July", "7:00 AM", address, "sample@sample.org");
            Outdoor outdoor = new Outdoor("Ward Picnic", "Come say hello to the ward!", "July 25", "12:00 PM", address, "Sunny weather. Bring a hat and sunscreen.");

            lecture.GetStandardDetails();
            lecture.GetFullDetails();
            lecture.GetShortDescription();

            reception.GetStandardDetails();
            reception.GetFullDetails();
            reception.GetShortDescription();

            outdoor.GetStandardDetails();
            outdoor.GetFullDetails();
            outdoor.GetShortDescription();

        }
    }
}