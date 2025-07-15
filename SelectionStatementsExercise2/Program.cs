namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();
            
            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I like some math!");
                    break;
                case "science":
                    Console.WriteLine("Science is my favorite subject!");
                    break;
                case "english":
                    Console.WriteLine("English is fun when you can be creative!");
                    break;
                case "history":
                    Console.WriteLine("History is boring as a school class!");
                    break;
                case "pe":
                case "p.e.":
                case "physical education":
                    Console.WriteLine("PE is my favorite subject!");
                    break;
                default:
                    Console.WriteLine("I like that too!");
                    break;
            }
        }
    }
}