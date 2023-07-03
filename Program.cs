namespace ConsoleApp_lesson1_home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the beginning of the range:");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the end of the range:");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start > end)  // Normalise 
            {
                int temp = start;
                start = end;
                end = temp;
            }

            Console.WriteLine($"Even numbers in the range from {start} to {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}