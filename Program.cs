namespace ConsoleApp_lesson1_home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter number from 1 to 100");
            number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}