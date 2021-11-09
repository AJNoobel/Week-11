using System;
using System.IO;
namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your color:");
            string userColor = Console.ReadLine();
            Console.WriteLine(GetColor(userColor));
        }



        public static string[] ReadColor()
        {
            string filePath = @"C:\Users\opilane\source\repos\TiTpe21\Week11-colors-personality-test-fail-main\personality.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);


            return dataFromFile;
        }



        public static string GetColor(string userInput)
        {
            string[] Color = ReadColor();
            string todayColor = "";

            foreach (string element in Color)
            {
                if (element.Contains(userInput))
                {
                    todayColor = element;
                }
            }
            return todayColor;


















        }
    }
}
