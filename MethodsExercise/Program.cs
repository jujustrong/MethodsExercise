namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite Holiday? ");
            string holiday = Console.ReadLine();
            Console.WriteLine("What is your favorite animal? ");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band? ");
            string favBand = Console.ReadLine();
            Console.WriteLine("What is your favorite venue? ");
            string venue = Console.ReadLine();
            
            Console.WriteLine($"{name} took thier pet {favAnimal} to see {favBand} at the legendary {venue} for the {holiday} festival!");
        }
    }
}
