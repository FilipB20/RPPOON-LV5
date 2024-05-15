namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Product product1 = new Product("opis", 2.5, 5);
            Product product2 = new Product("opis2", 22.5, 55);

            Box box = new Box("Prva kutija");
            Box box2 = new Box("Druga kutija");

            box2.Add(product1);
            box2.Add(product2);
            box.Add(box2);

            ShippingService shippingService = new ShippingService(1.5);

            Console.Write(shippingService.CalculateShippingFee(box));
            Console.Read();*/

            VirtualProxyDataset virtualProxyDataset = new VirtualProxyDataset("brojevi.csv");
            ProtectionProxyDataset protectionProxyDataset = new ProtectionProxyDataset(User.GenerateUser("Filip"));

            DataConsolePrinter printer = new DataConsolePrinter();

            printer.Print(virtualProxyDataset);
            printer.Print(protectionProxyDataset);
            Console.Read();

        }
    }
}