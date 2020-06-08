using System;

namespace GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            DateTime morning = new DateTime(2008, 3, 9, 9, 0, 0, 000);
            DateTime day = new DateTime(2008, 3, 9, 12, 0, 0, 000);
            DateTime evning = new DateTime(2008, 3, 9, 15, 0, 0, 000);
            DateTime night = new DateTime(2008, 3, 9, 22, 0, 0, 000);

            Console.WriteLine(time.TimeOfDay);
            if (time.TimeOfDay > morning.TimeOfDay && time.TimeOfDay < day.TimeOfDay)
            {
                Console.WriteLine("Good morning");
            }
            else if (time.TimeOfDay > day.TimeOfDay && time.TimeOfDay < evning.TimeOfDay)
            {
                Console.WriteLine("Good day");
            }
            else if (time.TimeOfDay > evning.TimeOfDay && time.TimeOfDay < night.TimeOfDay)
            {
                Console.WriteLine("Good night");
            }
            else
            {
                Console.WriteLine("Goodbay");
            }
        }
    }
}
