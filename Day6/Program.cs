namespace Day6
{
    class Program
    {
        private static int charCheckMarker = 4;

        private static int checkStateOfMarkerBit = 14;

        public static void Main(string[] args)
        {
            string[] testInputs = File.ReadAllLines("testinput.txt");
            foreach (var test in testInputs)
            {
                int firstMarkerCharLocation = parseString(test, charCheckMarker);
                Console.WriteLine($"The first marker occured after {firstMarkerCharLocation}");
            }
            string part1Input = File.ReadAllText("input.txt");
            int part1MarkerChar = parseString(part1Input, charCheckMarker);
            Console.WriteLine($"The first marker occured after {part1MarkerChar}");
            string[] part2Tests = File.ReadAllLines("testinputs2.txt");
            foreach (var test in part2Tests)
            {
                int secondMarkerCharLocation = parseString(test, checkStateOfMarkerBit);
                Console.WriteLine($"The second marker occured after {secondMarkerCharLocation}");
            }
            int part2MarkerChar = parseString(part1Input, checkStateOfMarkerBit);
            Console.WriteLine($"The first marker occured after {part2MarkerChar}");
        }

        public static int parseString(string input, int marker)
        {
            int counter = 0;
            bool loopDone = false;
            while (!loopDone)
            {
                HashSet<char> stringSet = new HashSet<char>();
                for (int i = 0; i < marker; i++)
                {
                    stringSet.Add(input[counter + i]);
                }
                if(stringSet.Count() == marker)
                {
                    loopDone = true;
                }
                else
                {
                    counter++;
                }
            }
            return counter += marker;
        }
    }
}
