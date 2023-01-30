using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace MethodsExercise
{
    public class Program
    {
        public static int Subtraction(int num1, int num2 )
        {
            return num1 - num2;
        }
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public static double division(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulous(int num1, int num2)
        {
            return num1 % num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my name is Ian, I am going to make a story about you! lets start with your name?");
            string userName = Console.ReadLine();

            Console.Write($"Nice to meet you {userName}! What was the name of your favorite pet growing up?");
            string petname = Console.ReadLine();

            Console.WriteLine($"{petname} is an adorable name, my favorite pets name is Rosie! where do you work {userName}?");
            string Work = Console.ReadLine();

            Console.WriteLine($"You work at {Work} that sounds really cool! what is the name of your bestfriend at work?");
            String bffName = Console.ReadLine();

            Console.WriteLine($"{bffName} is such a nice name! so let me get this right! Your name is {userName}, and your favorite pets name is {petname}, and you work with {bffName} at {Work}. That gives me all the info for my story!");
            Console.WriteLine();

            Console.WriteLine($"Once upon a time {userName} was walking in the park with {petname}. when they came across {bffName}, they sat and rambled on for hours before realizing that they were both going to be late for work at {Work}. So {userName} ran home as fast as they could and got ready for work to bad {userName} didn't make it on time.");
                Console.WriteLine();
            

            // math calculations
            int result = Subtraction(10, 5);
            Console.WriteLine(result);

            int result2 = Multiplication(10, 5);
            Console.WriteLine(result2);

            int result3 = Addition(10, 5);
            Console.WriteLine(result3);

            double result4 = division(10, 5);
            Console.WriteLine(result4);

            int result5 = Modulous(10, 5);
            Console.WriteLine(result5);

                
            
            
        }
        /*
        public static int Subtraction(params int[] results)
        {
            int result = 0;
            return results; 
        }
        */
        // This is a close as I could get to understanding the Params Keyword
        
        }

        

    }
}
