using Helper;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace Paper1
{
    public class RouteHandle
    {
        public static void Handler()
        {
            var routes = CreateRoutes();

            Array.Sort(routes, (x, y) => x.RouteNumber.CompareTo(y.RouteNumber));

            
            

            while (true)
            {
                Console.WriteLine($"f - найти маршут\ns - сохранить в файл\ne - выйти");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "f":
                    {
                        Console.Write("Введите номер маршрута: ");
                        int searchRouteNumber = Convert.ToInt32(Console.ReadLine());

                        var route = GetRouteByRouteNumber(routes, searchRouteNumber);

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

        public static Route[] CreateRoutes()
        {
            var routes = new Route[8];

            Console.WriteLine("Заполняться будет только один маршрут, потомучто каждый раз делать это 8 раз мне кажется безсмысленным (остальные уже заполнены):");
            Console.WriteLine("Route: ");
            Console.Write("Начальная точка: ");
            string startPoint = Console.ReadLine();
            Console.Write("Конечная точка: ");
            string endPoint = Console.ReadLine();
            Console.Write("Номер маршрута: ");
            int routeNumber;
            try
            {
                routeNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Номер маршрута должен быть целым числом. Номер маршрута будет присвоен по умолчанию");
                routeNumber = 1;
            }

            var route = new Route(startPoint, endPoint, routeNumber);
            routes[0] = route;

            routes[1] = new Route("Earth", "Valhala", ++routeNumber);
            routes[2] = new Route("Dutingem", "Loud", ++routeNumber);
            routes[3] = new Route("Rahil", "Grave", ++routeNumber);
            routes[4] = new Route("Baam", "101 floar", ++routeNumber);
            routes[5] = new Route("Cinec", "Gilberg", ++routeNumber);
            routes[6] = new Route("ASU", "JDAU", ++routeNumber);
            routes[7] = new Route("Garden of Eden", "Hell", ++routeNumber);

            return routes;
        }

        public static Route? GetRouteByRouteNumber(Route[] routes, int searchRouteNumber)
        {
            Route? route = null;
            for (int i = 0; i < routes.Length; i++)
            {
                if (routes[i].RouteNumber == searchRouteNumber)
                {
                    route = routes[i];
                }
            }
            
            return route;
        }

    }
}
