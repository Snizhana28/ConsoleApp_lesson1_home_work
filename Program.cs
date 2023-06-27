namespace ConsoleApp_lesson1_home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four numbers : ");
            int[] digits = new int[4];

            for (int i = 0; i < digits.Length; i++)
            {
                while(true)
                {
                    Console.WriteLine($"Number {i + 1} : ");
                    if (int.TryParse(Console.ReadLine(), out int digit) && digit >= 0 && digit <=9)
                    {
                        digits[i] = digit;
                        break;
                    }
                    else
                        Console.WriteLine("ERROR!\nEnter a number : ");
                }
            }
            int number = digits[0] * 1000 + digits[1] * 100 + digits[2] * 10 + digits[3];
            Console.WriteLine($"Your number is {number}");
        }
    }
}