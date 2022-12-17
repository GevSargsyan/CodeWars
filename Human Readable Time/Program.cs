using System;

namespace Human_Readable_Time
{
    internal class Program
    {
        public static string GetReadableTime(int input)
        {
            if (input == 0)
            {
                return "00:00:00";
            }
       
            if (input>0 && input < 360000)
            {
                int hours, minutes, seconds;
                string hoursStr, minutesStr, secondsStr;

                hours = input / 3600;
                minutes = (input - (hours * 3600))/60;
                seconds = input % 60;

                 hoursStr = hours < 10 ? "0" + hours : hours.ToString();
                 minutesStr = minutes < 10 ? "0" + minutes : minutes.ToString();
                 secondsStr = seconds < 10 ? "0" + seconds : seconds.ToString();

                return $"{hoursStr}:{minutesStr}:{secondsStr}";
             

            }
         
            return " ";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetReadableTime(45336));

            Console.WriteLine("{0:d2}",110/10);
        }
    }
}
