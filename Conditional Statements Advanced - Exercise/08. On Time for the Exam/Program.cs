using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hour_of_exam = int.Parse(Console.ReadLine());
            int Minute_of_exam = int.Parse(Console.ReadLine());
            int Hour_of_arrival = int.Parse(Console.ReadLine());
            int Minute_of_arrival = int.Parse(Console.ReadLine());

            int Time_of_Exam = (Hour_of_exam * 60) + Minute_of_exam;
            int Arrival_to_Exam = (Hour_of_arrival * 60) + Minute_of_arrival;

            int Time_difference = Arrival_to_Exam - Time_of_Exam;

            string state_of_arrival = string.Empty;

            if (Time_difference < -30) //early
            {
                state_of_arrival = "Early";
            }
            else if (Time_difference <= 0) //early
            {
                state_of_arrival = "On time";
            }
            else //late
            {
                state_of_arrival = "Late";
            }


            string result = string.Empty;

            if (Time_difference != 0)
            {
                int Hour_difference = Math.Abs(Time_difference / 60);
                int minute_diff = Math.Abs(Time_difference % 60);

                if (Hour_difference > 0)
                {
                    result = string.Format("{0}:{1:00} hours", Hour_difference, minute_diff);
                }
                else
                {
                    result = $"{minute_diff} minutes";
                }


                if (Time_difference < 0)
                {
                    result += " before the start";
                }
                else
                {
                    result += " after the start";
                }

                Console.WriteLine(state_of_arrival);
                if (!String.IsNullOrEmpty(result))
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine(state_of_arrival);
            }
        }
    }
}
