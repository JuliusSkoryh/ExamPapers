namespace PricePaper
{
    public record Product
    {
        public string ProductName { get; set; }
        public string ShopName { get; set; }
        public decimal Price { get; set; }

        public Product(string productName, string shopName, decimal price)
        {
            ProductName = productName;
            ShopName = shopName;
            Price = price;
        }

        public static Product[] CreateProduct()
        {
            var products = new Product[8];

            Console.WriteLine("Заполняться будет только один продукт, потомучто каждый раз делать это 8 раз мне кажется безсмысленным (остальные уже заполнены):");
            Console.WriteLine("Product: ");
            Console.Write("Имя продукта: ");
            string productName = Console.ReadLine();
            Console.Write("Имя магазина: ");
            string shopName = Console.ReadLine();
            
            int price;
            while (true)
            {
                Console.Write("Цена продукта: ");
                try
                {
                    price = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверно заданный параметр");
                }
            }

            var product = new Product(productName, shopName, price);
            products[0] = product;

            products[1] = new Product("AT-15", "DNS", 11000);
            products[2] = new Product("IPhone 11", "DNS", 22000);
            products[3] = new Product("IPad 20 pro", "DNS", 80000);
            products[4] = new Product("HyperX Jus", "DNS", 16800);
            products[5] = new Product("Logitech 200x", "Azon", 9000);
            products[6] = new Product("Golu 1", "Azon", 32000);
            products[7] = new Product("Golu 2 pro", "Azon", 89200);

            return products;
        }
    }
}
