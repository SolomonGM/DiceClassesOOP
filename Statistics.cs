using System;
using System.Xml.Linq;

namespace Three_Class_Task
{
    public class Statistics
    {
        public int TotalPlays { get; private set; } = 0; // Initialize TotalPlays to 0
        public int TotalScore { get; private set; } = 0; // Initialize Highscore to 0
        private readonly string statsFile = "stats.txt"; // File to save statistics

        public void IncrementTotalPlays()
        {
            TotalPlays++; // Increment TotalPlays by after game is played
        }
        public int UpdateStatistics(int score)
        {
            TotalScore += score; // Update totalScore with the latest score
            return TotalScore;
        }
        public void SaveStatistics()
        {
            string solutionDirectory = AppDomain.CurrentDomain.BaseDirectory; // Get the solution directory
            string fullPath = Path.Combine(solutionDirectory, statsFile); // Combine the solution directory with the stats file

            IncrementTotalPlays(); // Increment the total plays before saving the statistics
            UpdateStatistics(TotalScore); // Update the statistics before saving

            List<string> stats = new List<string>() // Create a list of statistics to save to the file
            {
                $"TotalPlays= {TotalPlays}",
                $"TotalScore= {TotalScore}"
            };

            Console.WriteLine($"Statistics saved to file at: {fullPath}"); // Display the full path to the file
            File.WriteAllLines(statsFile, stats); // Write the statistics to the file
        }
        public void DisplayStats()
        {
            Console.WriteLine("Would you like to save the statistics to a file? (Y/N)");

            string choice = Console.ReadLine().ToLower();

            if (choice == "y")
            {
                SaveStatistics();
                Console.WriteLine("Statistics saved to file... Check file directory!");
            }
            else
            {
                Console.WriteLine($"TotalPlays: {TotalPlays}, TotalScore: {TotalScore}");
                Console.WriteLine("No statistics saved to file.");
            }
        }
    }
}
