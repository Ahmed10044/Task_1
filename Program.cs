namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int costSmall = 25;
            int costLarge = 35;
            double taxP = (double)6 / 100;
            Console.Write("Number of small carpets:");
            int SmallNumbers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets:");
            int LargeNumbers = Convert.ToInt32(Console.ReadLine());
            int total = (costSmall * SmallNumbers) + (costLarge * LargeNumbers);
            Console.WriteLine($"Price per small room:{costSmall}");
            Console.WriteLine($"Price per large room:{costLarge}");
            Console.WriteLine($"cost :{total}");
            Console.WriteLine($"Tax :{total*taxP}");
            Console.WriteLine("====================================");
            Console.WriteLine($"Total estimate:{total*taxP+total}\nThis estimate is valid for 30 days");

        }
    }
}
