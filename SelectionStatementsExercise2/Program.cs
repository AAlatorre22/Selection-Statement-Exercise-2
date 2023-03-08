using System.Runtime.CompilerServices;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("2 + 2 = COOL!");
                    break;
                case "science":
                    Console.WriteLine("Science rocks!");
                    break;
                case "english":
                    Console.WriteLine("Write on!!");
                    break;
                case "history":
                    Console.WriteLine("Back in my day...");
                    break;
                case "recess":
                    Console.WriteLine("Go shower, you're all sweaty!");
                    break;
                case "lunch":
                    Console.WriteLine("We can be friends");
                    break;
                default:
                    Console.WriteLine("I never took that class.");
                    break;
            }
        }
    }
}