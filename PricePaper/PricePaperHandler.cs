using Helper;

namespace PricePaper
{
    public class PricePaperHandler
    {
        public static void Paper9Handler()
        {
            var products = Product.CreateProduct();

            Array.Sort(products, (x, y) => x.ProductName.CompareTo(x.ProductName));

            while (true)
            {
                Console.Write("Введите название файла: ");
                string fileName = Console.ReadLine();
                if (fileName != null)
                {
                    WriteToJson.WriteToFileAsJson(products, fileName);
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректное имя файла.");
                }
            }

            string productName;
            while (true)
            {
                Console.Write("Введите имя товара для поиска: ");
                productName = Console.ReadLine();
                if(String.IsNullOrEmpty(productName))
                {
                    Console.WriteLine("Параметр указан неправельно.");
                }
                else
                {
                    break;
                }
            }


            bool isFound = false;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductName == productName)
                {
                    isFound = true;
                    Console.WriteLine($"Found:\n\tProduct name: {products[i].ProductName}\n\tShop name: {products[i].ShopName}\n\tPrice: {products[i].Price}");
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Продукт не найден.");
            }
        }

        public static void Paper10Handler()
        {
            var products = Product.CreateProduct();

            Array.Sort(products, (x, y) => x.ShopName.CompareTo(x.ShopName));

            while (true)
            {
                Console.Write("Введите название файла: ");
                string fileName = Console.ReadLine();
                if (fileName != null)
                {
                    WriteToJson.WriteToFileAsJson(products, fileName);
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректное имя файла.");
                }
            }

            string shopName;
            while (true)
            {
                Console.Write("Введите имя магазина для поиска: ");
                shopName = Console.ReadLine();
                if (String.IsNullOrEmpty(shopName))
                {
                    Console.WriteLine("Параметр указан неправельно.");
                }
                else
                {
                    break;
                }
            }


            bool isFound = false;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ShopName == shopName)
                {
                    isFound = true;
                    Console.WriteLine($"Found:\n\tProduct name: {products[i].ProductName}\n\tShop name: {products[i].ShopName}\n\tPrice: {products[i].Price}");
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Магазин не найден.");
            }
        }
    }
}
