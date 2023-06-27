namespace ConsoleApp_lesson1_home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a six-digit number : ");
            string ?number = Console.ReadLine();
            if (number.Length != 6)
            {
                Console.WriteLine("Error! Enter a six-digit number : ");
                number = Console.ReadLine();
            }
            Console.WriteLine("Enter a position1 for replacement : ");
            int position1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a position2 for replacement : ");
            int position2 = Convert.ToInt32(Console.ReadLine());
             
            if (position1 == position2 || position1 > 6 || position2 > 6 || position1 < 0 || position2 < 0)
            {
                Console.WriteLine("Error!");
                return;
            }
            if (position1 > position2)
            {
                int temp = position1;
                position1 = position2;
                position2 = temp;
            }
            char[] array = number.ToCharArray();
            char temp1 = array[position1 - 1];
            char temp2 = array[position2 - 1];
            array[position1 - 1] = temp2;
            array[position2 - 1] = temp1;
            string result = new string(array);
            Console.WriteLine(result);
        }
    }
}