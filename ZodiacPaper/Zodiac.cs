using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacPaper
{
    public record Zodiac
    {
        private readonly string _zodiacSign;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ZodiacSign => _zodiacSign;
        public int[] DateOfBirth { get; set; }


        public Zodiac(string firstName, string lastName, int[] dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;

            if (dateOfBirth.Length == 3)
            {
                DateOfBirth = dateOfBirth;
            }

            if (dateOfBirth != null)
            {
                _zodiacSign = GetZodiacSign(dateOfBirth[0], dateOfBirth[1]);
            }
        }

        public static string GetZodiacSign(int day, int month)
        {
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return "овен";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return "телец";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                return "близнецы";
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                return "рак";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "лев";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "дева";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "весы";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "скорпион";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "стрелец";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return "козерог";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return "водолей";
            else
                return "рыбы";
        }

        public static Zodiac[] CreateZodiac()
        {
            var zodiacs = new Zodiac[8];

            Console.WriteLine("Заполняться будет только один человек, потомучто каждый раз делать это 8 раз мне кажется безсмысленным (остальные уже заполнены):");
            Console.WriteLine("Zodiac: ");
            Console.Write("Имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Фамилия: ");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("Дата рождения: ");
            int day, month, year;
            while (true)
            {
                Console.Write("\tдень: ");
                day = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > 31)
                {
                    Console.WriteLine("Неверно заданный параметр");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.Write("\tмесяц: ");
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Неверно заданный параметр");
                }
                else
                {
                    break;
                }

            }
            while (true)
            {
                Console.Write("\tгод: ");
                year = Convert.ToInt32(Console.ReadLine());
                if (year < 1900 || year > DateOnly.MaxValue.Year)
                {
                    Console.WriteLine("Неверно заданный параметр");
                }
                else
                {
                    break;
                }

            }

            var note = new Zodiac(firstName, lastName, [day, month, year]);
            zodiacs[0] = note;

            zodiacs[1] = new Zodiac("Jhone", "Stalone", [01, 02, 1991]);
            zodiacs[2] = new Zodiac("Ron", "Withly", [31, 12, 2001]);
            zodiacs[3] = new Zodiac("Abe", "Irush", [04, 10, 1920]);
            zodiacs[4] = new Zodiac("Islam", "Mabek", [27, 09, 2007]);
            zodiacs[5] = new Zodiac("Jusick", "Touma", [01, 02, 1991]);
            zodiacs[6] = new Zodiac("Mo", "Mo", [07, 07, 1907]);
            zodiacs[7] = new Zodiac("Philat", "Rokuske", [22, 05, 1950]);

            return zodiacs;
        }

    }
}
