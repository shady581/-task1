namespace اله_حاسبة_معرفة_سجاز_بكام_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Pricesmallroom = 25;

            int Pricesbigroom = 35;
            double taxrate = 0.06;

            Console.WriteLine("enter number small carpets");
            int numbersmallcarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number big carpets");
            int numberbigcarpets = Convert.ToInt32(Console.ReadLine());

            double cost = (numbersmallcarpets * Pricesmallroom) + (numberbigcarpets * Pricesbigroom);
            Console.WriteLine($" cost is befort taxrate is{cost}");

            double totalcost = (cost * taxrate);

            Console.WriteLine($"total cost after taxrate is{totalcost}");


        }
    }
}
