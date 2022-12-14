using System.Xml.Linq;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // my guess number is 25 and I want to use a list to count the number of tires before the correct guess number
            var tries = new List<int> { };
            int guess = 25;

            while (true)
            {
                
                Console.WriteLine("Guess my number");
                int input = Convert.ToInt32(Console.ReadLine());

                // recording the number of tries
                if (tries.IndexOf(input) == -1)
                {
                    tries.Add(input);
                }
                
                // checking for the guesses
                if (input > guess + 10)
                {
                    Console.WriteLine("Your number is too large");
                }
                else if (input < guess - 10)
                {
                    Console.WriteLine("Your number is too small");
                }
                else if (input < guess && input > guess - 10)
                {
                    Console.WriteLine("Your number is a little small");
                }
                else if (input > guess && input < guess + 10)
                {
                    Console.WriteLine("Your number is a little big");
                }
                else if (input == guess)
                {
                    Console.WriteLine("Congrats");
                    break;
                }
            // this is doing number except adding space for readable output
                Console.WriteLine(" ");

            }
            
            Console.WriteLine($"You made {tries.Count} tries");
        }
    }
}
