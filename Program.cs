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
            LoggingProxy loggingProxy=new LoggingProxy(virtualProxyDataset);
            ProtectionProxyDataset protectionProxyDataset = new ProtectionProxyDataset(User.GenerateUser("Filip"));
            LoggingProxy loggingProxy2=new LoggingProxy(protectionProxyDataset);
            DataConsolePrinter printer = new DataConsolePrinter();

            printer.Print(loggingProxy);
            printer.Print(loggingProxy2);
            Console.Read();

        }
    }
}