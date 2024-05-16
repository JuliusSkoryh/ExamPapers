using Helper;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NotePaper
{
    public class NotePaperHandler
    {
        public static void Paper3Handler()
        {
            var notes = CreateNotes();
            Array.Sort(notes, (x, y) => x.DateOfBirth[2].CompareTo(y.DateOfBirth[2]));

            while (true)
            {
                Console.Write("Имя файла: ");
                string fileName = Console.ReadLine();
                if (fileName != null)
                {
                    WriteToJson.WriteToFileAsJson(notes, fileName);
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректное имя файла.");
                }
            }



            Console.WriteLine("Введите номер телефона для поиска:");
            string phoneNumberToSearch = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i].PhoneNumber == phoneNumberToSearch)
                {
                    Console.WriteLine($"Found: {notes[i].FirstName} {notes[i].LastName}, {notes[i].DateOfBirth[0]}.{notes[i].DateOfBirth[1]}.{notes[i].DateOfBirth[2]}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Такой записи не сущеествует.");
            }

        }

        public static void Paper4Handler()
        {
            var notes = CreateNotes();
            Array.Sort(notes, (x, y) => string.Compare(x.LastName, y.LastName));

            while (true)
            {
                Console.Write("Имя файла: ");
                string fileName = Console.ReadLine();
                if (fileName != null)
                {
                    WriteToJson.WriteToFileAsJson(notes, fileName);
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректное имя файла.");
                }
            }



            Console.WriteLine("Введите номер телефона для поиска:");
            int month = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i].DateOfBirth[1] == month)
                {
                    Console.WriteLine($"Found: {notes[i].FirstName} {notes[i].LastName}, {notes[i].DateOfBirth[0]}.{notes[i].DateOfBirth[1]}.{notes[i].DateOfBirth[2]}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Такой записи не сущеествует.");
            }

        }

        public static void Paper5Handler()
        {
            var notes = CreateNotes();
            Array.Sort(notes, (x, y) => String.Compare(x.PhoneNumber.Substring(0, 3), y.PhoneNumber.Substring(0, 3)));

            while (true)
            {
                Console.Write("Имя файла: ");
                string fileName = Console.ReadLine();
                if (fileName != null)
                {
                    WriteToJson.WriteToFileAsJson(notes, fileName);
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректное имя файла.");
                }
            }



            Console.WriteLine("Введите номер телефона для поиска:");
            int month = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i].DateOfBirth[1] == month)
                {
                    Console.WriteLine($"Found: {notes[i].FirstName} {notes[i].LastName}, {notes[i].DateOfBirth[0]}.{notes[i].DateOfBirth[1]}.{notes[i].DateOfBirth[2]}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Такой записи не сущеествует.");
            }

        }


        private static Note[] CreateNotes()
        {
            var notes = new Note[8];
            

            Console.WriteLine("Заполняться будет только одина заметка, потомучто каждый раз делать это 8 раз мне кажется безсмысленным (остальные уже заполнены):");
            Console.WriteLine("Note: ");
            Console.Write("Имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Фамилия: ");
            string lastName = Console.ReadLine();
            Console.Write("Номер телефона (##########): ");
            string phoneNumber;
            while (true)
            {
                phoneNumber = Console.ReadLine();
                if(phoneNumber.Length != 10)
                {
                    Console.WriteLine("неправильный номер телефона");
                }
                else
                {
                    break;
                }
            }
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

            var note = new Note(firstName, lastName, phoneNumber, [day,  month, year]);
            notes[0] = note;

            notes[1] = new Note("Jhone", "Stalone", "1112223344", [01, 02, 1991]);
            notes[2] = new Note("Ron", "Withly", "9528196680", [31, 12, 2001]);
            notes[3] = new Note("Abe", "Irush", "7893453849", [04, 10, 1920]);
            notes[4] = new Note("Islam", "Mabek", "8745298552", [27, 09, 2007]);
            notes[5] = new Note("Jusick", "Touma", "3487762688", [01, 02, 1991]);
            notes[6] = new Note("Mo", "Mo", "1112248890", [07, 07, 1907]);
            notes[7] = new Note("Philat", "Rokuske", "2347896677", [22, 05, 1950]);

            return notes;
        }
    }
}
