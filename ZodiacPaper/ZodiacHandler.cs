using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacPaper
{
    public class ZodiacHandler
    {
        public static void Paper6Handler()
        {
            var zodiac = Zodiac.CreateZodiac();

            Array.Sort(zodiac, (x, y) => x.DateOfBirth[2].CompareTo(y.DateOfBirth[2]));

            while (true)
            {
                Console.Write("Введите название файла: ");
                string fileName = Console.ReadLine();
                if (fileName != null)
                {
                    WriteToJson.WriteToFileAsJson(zodiac, fileName);
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректное имя файла.");
                }
            }

            Console.Write("Введите фамилию для поиска: ");
            string lastName = Console.ReadLine();
            bool isFound= false;
            for (int i = 0; i < zodiac.Length; i++)
            {
                if (zodiac[i].LastName == lastName)
                {
                    isFound = true;
                    Console.WriteLine($"Found: {zodiac[i].FirstName} {zodiac[i].LastName}, {zodiac[i].DateOfBirth[0]}.{zodiac[i].DateOfBirth[1]}.{zodiac[i].DateOfBirth[2]}, zodiac sign is {zodiac[i].ZodiacSign}.");
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Пользователь не найден.");
            }
        }

        public static void Paper7Handler()
        {
            var zodiac = Zodiac.CreateZodiac();

            Array.Sort(zodiac, (x, y) => x.DateOfBirth[2].CompareTo(y.DateOfBirth[2]));

            while (true)
            {
                Console.Write("Введите название файла: ");
                string fileName = Console.ReadLine();
                if (fileName != null)
                {
                    WriteToJson.WriteToFileAsJson(zodiac, fileName);
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректное имя файла.");
                }
            }

            Console.Write("Введите знак задиака для поиска: ");
            string zodiacSign = Console.ReadLine().ToLower();
            bool isFound = false;
            for (int i = 0; i < zodiac.Length; i++)
            {
                if (zodiac[i].ZodiacSign == zodiacSign)
                {
                    isFound = true;
                    Console.WriteLine($"Found: {zodiac[i].FirstName} {zodiac[i].LastName}, {zodiac[i].DateOfBirth[0]}.{zodiac[i].DateOfBirth[1]}.{zodiac[i].DateOfBirth[2]}, zodiac sign is {zodiac[i].ZodiacSign}.");
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Пользователь не найден.");
            }
        }

        public static void Paper8Handler()
        {
            var zodiac = Zodiac.CreateZodiac();

            Array.Sort(zodiac, (x, y) => x.DateOfBirth[2].CompareTo(y.DateOfBirth[2]));

            while (true)
            {
                Console.Write("Введите название файла: ");
                string fileName = Console.ReadLine();
                if (fileName != null)
                {
                    WriteToJson.WriteToFileAsJson(zodiac, fileName);
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректное имя файла.");
                }
            }

            int month;
            while (true)
            {
                Console.Write("Введите месяц (целое число) для поиска: ");
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if (month == 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Параметр указан неправельно.");
                }
            }

            
            bool isFound = false;
            for (int i = 0; i < zodiac.Length; i++)
            {
                if (zodiac[i].DateOfBirth[1] == month)
                {
                    isFound = true;
                    Console.WriteLine($"Found: {zodiac[i].FirstName} {zodiac[i].LastName}, {zodiac[i].DateOfBirth[0]}.{zodiac[i].DateOfBirth[1]}.{zodiac[i].DateOfBirth[2]}, zodiac sign is {zodiac[i].ZodiacSign}.");
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Пользователь не найден.");
            }
        }


    }
}
