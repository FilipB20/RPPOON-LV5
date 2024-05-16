namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            // TEST 1,2

            Product product1 = new Product("Opis producta", 2.5, 5);
            Product product2 = new Product("Opis drugog producta", 22.5, 55);

            Box box = new Box("Prva kutija");
            Box box2 = new Box("Druga kutija");

            box2.Add(product1);
            box2.Add(product2);
            box.Add(box2);

            ShippingService shippingService = new ShippingService(1.5);

            Console.Write($"{box.Description()} Weight:{box.Weight} Price:{box.Price}\n");
            Console.Write("Shipping fee:"+shippingService.CalculateShippingFee(box)+"\n");


            // TEST 3,4

            VirtualProxyDataset virtualProxyDataset = new VirtualProxyDataset("brojevi.csv");
            LoggingProxy loggingProxy=new LoggingProxy(virtualProxyDataset);

            ProtectionProxyDataset protectionProxyDataset = new ProtectionProxyDataset(User.GenerateUser("Filip"));
            ProtectionProxyDataset unauthorizedProtectionProxyDataset = new ProtectionProxyDataset(User.GenerateUser("Josip"));

            LoggingProxy loggingProxy2 =new LoggingProxy(protectionProxyDataset);
            LoggingProxy unauthorizedLoggingProxy2 = new LoggingProxy(unauthorizedProtectionProxyDataset);

            DataConsolePrinter printer = new DataConsolePrinter();
            printer.Print(loggingProxy);
            printer.Print(loggingProxy2);
            printer.Print(unauthorizedLoggingProxy2);
            Console.Write("\n");

            // TEST 5,6,7

            LightTheme lightTheme=new LightTheme();
            GrayTheme grayTheme=new GrayTheme();
            grayTheme.SetBackgroundColor();
            grayTheme.SetFontColor();

            Notebook notebook=new Notebook(lightTheme);
            notebook.ChangeTheme(lightTheme);
            ReminderNote reminderNote = new ReminderNote("Kolokvij", lightTheme);
            ReminderNote reminderNote2 = new ReminderNote("Labos", grayTheme);
            GroupNote groupNote=new GroupNote("Seminar",lightTheme);

            groupNote.Add("Filip");
            groupNote.Add("Josip");
            groupNote.Show();


            notebook.AddNote(reminderNote);
            notebook.AddNote(reminderNote2);
            notebook.AddNote(groupNote);
            notebook.Display();

            notebook.ChangeTheme(grayTheme);
            notebook.Display();
            Console.Read();

        }
    }
}