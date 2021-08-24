using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //5 inputs for madlibs
            Console.WriteLine("Enter an adjective: ");
            string adjective = Console.ReadLine();
            Console.WriteLine("\nEnter a noun(alive): ");
            string noun = Console.ReadLine();
            Console.WriteLine("\nEnter a verb (past tense): ");
            string verb = Console.ReadLine();
            Console.WriteLine("\nEnter a noun: ");
            string nounTwo = Console.ReadLine();
            Console.WriteLine("\nEnter a verb :");
            string verbTwo = Console.ReadLine();

            //3 differant stories
            string storyOne = "\n\nThe " + adjective + " " + noun + " " + verb + " to the " + nounTwo + " to" +
                "" +
                " " + verbTwo + ".";
            string storyTwo = "\n\nMy " + adjective + " " + noun + " " + verb + " into a " + nounTwo + " to " + verbTwo +".";
            string storyThree = "\n\nA " + verb + " " + noun + " that was " + adjective + ", " + verbTwo + " at the " + nounTwo + ".";

            //an array of stories
            string[] allSotries = {storyOne, storyTwo, storyThree};

            //picking a story at random to implement into the console
            int num = rand.Next(3);

            //final output
            Console.WriteLine(allSotries[num]);

        }
    }
}
