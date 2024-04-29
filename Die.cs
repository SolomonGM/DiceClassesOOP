using System;
using System.Diagnostics;
using System.Linq;

namespace Three_Class_Task
{
    class Testing : Game
    {
        public override int PlayGame() => 0;  // No implementation needed for abstract member

        public void RunTests()
        {
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Test Roll Dices");
                Console.WriteLine("2. Test SevenOut");
                Console.WriteLine("3. Test ThreeOrMore");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TestRollDices();
                        break;
                    case "2":
                        TestSevenOut();
                        break;
                    case "3":
                        TestThreeOrMore();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void TestRollDices()
        {
            SevenOut game = new SevenOut(); // Create a SevenOut game instance.
            game.CreateDie(3); // Create 3 dice.
            int[] rolls = game.RollDie(); // Roll the dice and capture the results.

            // Ensure each die roll is within the valid range (1-6).
            foreach (var roll in rolls)
            {
                Debug.Assert(roll >= 1 && roll <= 6, $"Test Failed: {roll}. Roll should be between 1 and 6.");
            }

            Console.WriteLine("Test Roll Dices Passed."); // Confirm the test passed if no assertions failed.
        }

        private void TestSevenOut()
        {
            SevenOut game = new SevenOut();
        
            game.PlayGame();  // This assumes you have a way to mock dice roll outcomes

            int total = game.PlayGame();
            Debug.Assert(total == 7, "Test Failed: Game should have stopped with a total sum of 7.");
            Console.WriteLine("Test SevenOut Passed.");
        }

        private void TestThreeOrMore()
        {
            ThreeOrMore game = new ThreeOrMore();
            
            game.TestGame();  // This also assumes methods to mock scores

            game.PlayGame();
            Debug.Assert(game.TotalPoints >= 20, "Test Failed: Total points should be 20 or more.");
            Console.WriteLine("Test Three Or More Passed.");
        }
    }
}


