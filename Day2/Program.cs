namespace Day2
{
    class Program
        {
            static void Main(string[] args)
            {
                string[] fileContents = File.ReadAllLines("input.txt");
                long score = 0;
                long part2Score = 0;
                foreach (var outcomeSet in fileContents)
                {
                    string[] outcomes = outcomeSet.Split(" ");
                    CompetitorHandShape competitorHandShape = HandShapeFactory.GetCompetitorHandShape(outcomes[0]);
                    PlayerHandShape playerHandShape = HandShapeFactory.GetPlayerHandShape(outcomes[1]);
                    score += playerHandShape.GetOutCome(competitorHandShape);
                    part2Score += HandShapeFactory.GetScore(competitorHandShape, outcomes[1]);
                }
                Console.WriteLine($"The score for the game was {score}");
                Console.WriteLine($"The Part2 Score for the game was {part2Score}");
            }
        }
}