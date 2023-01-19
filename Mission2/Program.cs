using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dic throwing simulator!\n");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            string rollInput = Console.ReadLine();
            int totalRolls = Int32.Parse(rollInput);

            int[] rollResults = new int[12];

            Random random = new Random();

            //Simulate rolls of 2 dice
            for (int i = 0; i < totalRolls; i++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                int totalRoll = die1 + die2;

                rollResults[totalRoll - 1]++;
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + totalRolls + "\n");

            for (int i = 1; i < 12; i++)
            {
                decimal results = rollResults[i];
                decimal rollNum = totalRolls;
                decimal perRolls = (results / rollNum);

                perRolls = Math.Round(perRolls * 100);

                string output = "";

                for (int j = 0; j < perRolls; j++)
                {
                    output += "*";
                }

                Console.WriteLine(i + 1 + ": " + output);
            }

            Console.WriteLine("\nThank you for using the dic throwing simulator. Goodbye!");
        }
    }
}
