using System;

namespace _1_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine(p.Shapes(3));
            Console.WriteLine(Months(1));
        }
        //using c#8 switch statement syntax
        public static string Months(int input)
        {
            return input switch
                {
                    1 => "January",
                    2 => "Febuary",
                    3 => "March",
                    4 => "April",
                    5 => "May",
                    6 => "June",
                    7 => "July",
                    8 => "August",
                    9 => "September",
                    10 => "October",
                    11 => "November",
                    12 => "December",
                    _ => "error, this is not a valid month"
                };
        }
        public string Shapes(int input)
        {
            return input switch
            {
                1 => "Circle",
                2 => "Semi-circle",
                3 => "Triangle",
                4 => "Square",
                5 => "Pentagon",
                6 => "Hexagon",
                7 => "Heptagon",
                8 => "October",
                9 => "Nonagon",
                10 => "Decagon",
                _ => "Please enter a number 1-10"
            };
        }
    }
}