using System.Runtime.CompilerServices;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my name is Ian, What is your name?");
            string userName = Console.ReadLine();

            Console.Write($"Nice to meet you {userName}! What was the name of your favorite pet growing up?");
            string petname = Console.ReadLine();

            Console.WriteLine($"{petname} is an adorable name, my favorite pets name is Rosie! where do you work {userName}?"); 
            string Work = Console.ReadLine();

            Console.WriteLine($"You work at {Work} that sounds really cool! what is the name of your bestfriend at work?");
            String bffName = Console.ReadLine();

            Console.WriteLine($"{bffName} is such a nice name! so let me get this right! Your name is {userName}, and your favorite pets name is {petname}, and you work with {bffName} at {Work}");
        }
    }
}
