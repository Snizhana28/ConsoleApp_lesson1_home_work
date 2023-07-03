namespace ConsoleApp_lesson1_home_work
{
    internal class Program
    {
        static string GetSeason(int month)
        {
            if (month >= 3 && month <= 5)
                return "Spring";
            else if (month >= 6 && month <= 8)
                return "Summer";
            else if (month >= 9 && month <= 11)
                return "Autumn";
            else
                return "Winter";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a data (day.month.year) : ");
            string input = Console.ReadLine();

            DateTime date;
            if (DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                string season = GetSeason(date.Month);
                string dayOfweek = date.ToString("dddd");

                Console.WriteLine($"{season} {dayOfweek}");
            }
            else
                Console.WriteLine("Invalid date format");
        }
    }
}