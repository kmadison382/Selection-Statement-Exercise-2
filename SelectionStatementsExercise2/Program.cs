namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "english":
                    Console.WriteLine("English? Hey, me too!");
                    break;
                case "math":
                    Console.WriteLine("Soo, I liked math...until it started to look more like English");
                    break;
                case "art":
                    Console.WriteLine("Ah, the arts...underappreciated, aren't they?");
                    break;
                case "science":
                    Console.WriteLine("Science! I love science!");
                    break;
                case "gym":
                case "pe":
                    Console.WriteLine("Gym? You mean like, running and sweating and dodgeball? No thanks!");
                    break;
                default:
                    Console.WriteLine($"{favSubject}? Oh... I don't think I ever took that class.");
                    break;

            }
        }
    }
}