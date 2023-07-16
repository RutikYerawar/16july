using System.Linq;
namespace labExam1
{
    internal class Program
    {
        static void Main()
        {
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            var days = from day in daysOfWeek select day;

            Console.WriteLine("Days of the week:");

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}
