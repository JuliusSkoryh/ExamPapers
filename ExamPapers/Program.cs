using Newtonsoft.Json;
using NotePaper;
using Paper1;
using ZodiacPaper;

namespace ExamPapers
{
    internal class Program
    {       

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Номер задания: ");
                int number;
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < 1 || number > 10)
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                catch
                {
                    Console.WriteLine("Невозможно найти номер задания. Будет присвоено значение по умолчанию (1).");
                    number = 1;
                }


                switch (number)
                {
                    case 1:
                        {
                            Paper1.RouteHandle.Handler();
                            break;
                        }
                    case 2:
                        {
                            Paper2.RouteHandle.Handler();
                            break;
                        }
                    case 3:
                        {
                            NotePaperHandler.Paper3Handler();
                            break;
                        }
                    case 4:
                        {
                            NotePaperHandler.Paper4Handler();
                            break;
                        }
                    case 5:
                        {
                            NotePaperHandler.Paper5Handler();
                            break;
                        }
                    case 6:
                        {
                            ZodiacHandler.Paper6Handler();
                            break;
                        }
                    case 7:
                        {
                            ZodiacHandler.Paper7Handler();
                            break;
                        }
                    case 8:
                        {
                            ZodiacHandler.Paper8Handler();
                            break;
                        }
                    case 9:
                        {
                            PricePaper.PricePaperHandler.Paper9Handler();
                            break;
                        }
                    case 10:
                        {
                            PricePaper.PricePaperHandler.Paper10Handler();
                            break;
                        }
                }
            }
        }
    }
}
