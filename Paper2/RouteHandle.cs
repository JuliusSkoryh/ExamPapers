

using Helper;
using Paper1;

namespace Paper2
{
    public class RouteHandle
    {

        public static void Handler()
        {
            var routes = Paper1.RouteHandle.CreateRoutes();

            Array.Sort(routes, (x, y) => x.RouteNumber.CompareTo(y.RouteNumber));

            while (true)
            {
                Console.WriteLine($"f - найти маршут\ns - сохранить в файл\ne - выйти");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "f":
                        {
                            Console.WriteLine("start - поиск начальной точки; end - поиск конечной точки;");
                            var serchСommand = Console.ReadLine();
                            Route? route = null;
                            if (serchСommand == "start")
                            {

                                Console.Write("Введите старт маршрута: ");
                                string startPoint = Console.ReadLine();
                                if (String.IsNullOrEmpty(startPoint))
                                {
                                    Console.WriteLine("Маршрут не введен некоректно");
                                }
                                else
                                {
                                    route = GetRouteByStartPoint(routes, startPoint);
                                }                                
                            }
                            else if (serchСommand == "end")
                            {
                                Console.Write("Введите конец маршрута: ");
                                string endPoint = Console.ReadLine();

                                route = GetRouteByEndPoint(routes, endPoint);
                            } 
                            else
                            {
                                Console.WriteLine("Неверная команда");
                                break;
                            }

                            if (route == null)
                            {
                                Console.WriteLine("Маршрут не найден");
                            }
                            else
                            {
                                Console.WriteLine("Маршрут " + route.RouteNumber + ": " + route.StartPoint + " в " + route.EndPoint);
                            }

                            break;
                        }
                    case "s":
                        {
                            Console.Write("Имя файла: ");
                            string fileName = Console.ReadLine();
                            var path = WriteToJson.WriteToFileAsJson(routes, fileName);
                            Console.WriteLine($"путь: {path}");

                            break;
                        }
                    case "e":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Неверная команда");
                            break;
                        }
                }
            }
        }


        public static Route? GetRouteByStartPoint(Route[] routes, string startPoint)
        {
            Route? route = null;
            for (int i = 0; i < routes.Length; i++)
            {
                if (routes[i].StartPoint == startPoint)
                {
                    route = routes[i];
                }
            }

            return route;
        }

        public static Route? GetRouteByEndPoint(Route[] routes, string endPoint)
        {
            Route? route = null;
            for (int i = 0; i < routes.Length; i++)
            {
                if (routes[i].EndPoint == endPoint)
                {
                    route = routes[i];
                }
            }

            return route;
        }
    }
}
