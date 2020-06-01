using System;

namespace ProgrammingAssignment1
{
    class Program
    {
        /// <summary>
        /// This program calculate the distance between two points and the angle between those points.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Print supporting message
            /*
            Console.WriteLine("My name: Carlos Rincon");
            Console.WriteLine();
            Console.WriteLine("Mi best friend: Paola Rincon");
            */
            //Integers
            /*
            int totalSecondsPlayed = 100; //Las variable empiezas con letra minuscula
            const int SecondsPerMinute = 60; //Las constantes empiezas con letra minuscula
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);
            int age = 24;
            Console.WriteLine("My age is: " + age);
            Console.Write("Enter first altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Enter second altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());
            Console.Write("Altitude change: " + (secondAltitude - firstAltitude));
            */
            //Float
            /*
            int MaxScore = 100;
            int score = 67;
            float percent = (float)score / MaxScore;
            Console.Write("Your score is: " + percent);            
            Console.Write("Set your angle in degrees: ");
            float angle = float.Parse(Console.ReadLine());
            float radians = (float) (angle * Math.PI / 180);
            Console.WriteLine("Cosine of oyur angle: " + Math.Cos(radians));
            Console.WriteLine("Sine of oyur angle: " + Math.Sin(radians));            
            float fahrenheit = 132;
            float celsius = ((fahrenheit - 32) / 9) * 5;
            Console.WriteLine("Celsius: " + celsius);
            fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            */

            //First, prompt for the values
            Console.WriteLine("Welcome Player 1!");
            Console.WriteLine();
            Console.WriteLine("Here you can calculate the distance between two points and the angle between those points.");
            Console.WriteLine("Please enter X for the first point: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Y for the first point: ");
            float point1Y = float.Parse(Console.ReadLine());
            Console.WriteLine("Now we need to get where is the second point!");
            Console.WriteLine("Please enter X for the second point: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Y for the second point: ");
            float point2Y = float.Parse(Console.ReadLine());

            //Calculate delta values
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            //Calculate the distance and the angle
            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            Console.WriteLine("The distance is: " + distance);
            double angle = (Math.Atan2(deltaX, deltaY) * 180) / Math.PI;
            Console.WriteLine("The angle is: " + angle);

        }
    }
}


