// See https://aka.ms/new-console-template for more information
namespace Loops
{
    class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++){
                Console.WriteLine($"Terje er kul {i+1}");
            }

            string textByChar = "Hei hå!";
            foreach (char letter in textByChar)
            {
                Console.WriteLine(letter);
            }

            int roundNumber = 1;
            while (roundNumber <= 10)
            {
                Console.WriteLine($"Round number {roundNumber}");
                roundNumber++;
            }
        }
    }
}