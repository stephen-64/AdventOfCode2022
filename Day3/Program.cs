namespace Day3
{
    class Program
        {
            static void Main(string[] args)
            {
                string[] fileContents = File.ReadAllLines("input.txt");
                List<BagContents> bags = new List<BagContents>();
                foreach (var item in fileContents)
                {
                    bags.Add(new BagContents(item));
                }
                int totalScore = bags.Sum(bagContents => bagContents.score);
                Console.WriteLine($"The total score for these bags was {totalScore}");
                List<BagContentsPart2> bagsForPart2 = new List<BagContentsPart2>();
                int bagCounter = 0;
                while (bagCounter + 2 < fileContents.Length)
                {
                    bagsForPart2.Add(new BagContentsPart2(fileContents[bagCounter++], fileContents[bagCounter++], fileContents[bagCounter++]));
                }
                int totalScorePart2 = bagsForPart2.Sum(BagContents => BagContents.score);
                Console.WriteLine($"The total score for the bags in part 2 was {totalScorePart2}");
            }
        }
}