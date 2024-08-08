using Microsoft.VisualBasic.CompilerServices;

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
            
            Console.WriteLine($"{name} took their pet {favAnimal} to see {favBand} " +
                              $"at the legendary {venue} for the {holiday} festival!");
        }

        
        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        
        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        static int Add(params int[] list)
        {
            int total = 0;
            for (int i = 0; i < list.Length; i++)
            {
                total += list[i];
            }

            return total;
        }
        
        static int Subtract(params int[] list)
        {
            int total = 0;
            for (int i = 0; i < list.Length; i++)
            {
                total -= list[i];
            }

            return total;
        }
    }
}
