using System;
using System.IO;
namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Horoscope Sign:");
            string userSign = Console.ReadLine();
            Console.WriteLine(GetHoroScope(userSign));
        }



        public static string[] ReadHoroScope()
        {
            string filePath = @"C:\Users\opilane\source\repos\TiTpe21\Week11-horoscope-file-main\horoscope.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            

            return dataFromFile;
        }
        public static string GetHoroScope(string userInput)
        {
            string[] horoscope = ReadHoroScope();
            string todayHoroScope ="";

            foreach(string element in horoscope)
            {
                if (element.Contains(userInput))
                {
                    todayHoroScope = element;
                }
            }
            return todayHoroScope;







        }





    }
}
