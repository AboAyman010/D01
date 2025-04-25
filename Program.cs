namespace Islam_Carpet_Cleaning_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Small Carpets ? ");
            int carp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of Large Carpets ? ");
            int carp2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("price per small Carpet : $25");
            Console.WriteLine("price pes large Carpet : $35");
            int cost = (carp1 * 25) + (carp2 * 35);
            Console.WriteLine($"the cost  : ${cost}");
            double tax = cost * 0.06 ;
            Console.WriteLine($"the Tax : ${tax}");
            double total = cost + tax;
            Console.WriteLine($" total estimate : ${total}" );
            Console.WriteLine("this estimate is valid for 30 days ");

        }
    }
}
