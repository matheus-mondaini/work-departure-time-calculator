using System;
using System.Linq;
using System.Globalization;
using static System.Console;

namespace Work_Departure_Time_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Are you leaving for class now? (y/n): ");
            string? is_leaving_now = ReadLine();
            DateTime class_time;
            if (is_leaving_now == "y"){
                class_time = DateTime.Now;
            }
            else
            {
                WriteLine("\nEnter the time you left for your class (in HH:mm format): ");
                string? string_class_time = ReadLine();
                if (!DateTime.TryParseExact(string_class_time, "HH:mm", null, System.Globalization.DateTimeStyles.None, out class_time)){
                        WriteLine("Invalid time! Make sure you enter the time in the correct format (HH:mm).");
                    }
            }    
            TimeSpan departure_time = new TimeSpan(13, 30, 00) - class_time.TimeOfDay;
            departure_time = departure_time.Add(new TimeSpan (8, 0, 0));
            departure_time = departure_time.Add(new TimeSpan (6, 0, 0));
            WriteLine($"\nUse: {departure_time.ToString(@"hh\:mm")} as your departure time\n");
        }
    }
}