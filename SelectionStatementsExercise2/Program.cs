namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var favoiteProj = (Console.ReadLine());

            switch (favoiteProj)
            {
                case "Math":
                case "math":
                    Console.WriteLine("Math is cool!");
                    break;
                case "English":
                case "english":
                    Console.WriteLine("English is fun!");
                    break;
                case "Science":
                case "science":
                    Console.WriteLine("Science is hard");
                    break;
                case "Art":
                case "art":
                    Console.WriteLine("Art is where you get to be creative!");
                    break;
                case "PE":
                case "pe":
                case "Physical Education":
                    Console.WriteLine("PE is always a good time!");
                    break;
                default:
                    Console.WriteLine("I'm sure that subject is great also!");
                    break;
            }
        }
    }
}