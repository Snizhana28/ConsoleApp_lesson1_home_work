namespace ConsoleApp_lesson1_home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber * secondNumber / 100;
            Console.WriteLine("Result : " + result);
        }
    }
}