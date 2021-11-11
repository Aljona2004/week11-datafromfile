using System;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your zodiac:");
            string userZodiac = Console.ReadLine();

            string output = (userZodiac);

            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry. Color not found.");
            }

        }
        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\Users\opilane\Samples";
            string fileName = "horoscope.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);

            return dataFromFile;
        }

        private static string GetLinesFromfileData(string userInput)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "";

            foreach (string line in dataFromFile)
            {
                if (line.Contains(userInput))
                {
                    result = line;
                    break;
                }
            }
            return result;
        }

    }
