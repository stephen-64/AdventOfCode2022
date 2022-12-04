namespace Day4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] testFile = File.ReadAllLines("testinput.txt");
            generateTestFileOutput(testFile);
            generateSecondTestFileOutput(testFile);
            testFile = File.ReadAllLines("input.txt");
            generateTestFileOutput(testFile);
            generateSecondTestFileOutput(testFile);
        }

        private static void generateTestFileOutput(string[] testFileContents)
        {
            List<ElfPairs> elfList = new List<ElfPairs>();
            foreach (var item in testFileContents)
            {
                elfList.Add(new ElfPairs(item));
            }
            Console.WriteLine($"There was {getSelfContainedElfCount(elfList)} self contained pair(s)");
        }

        private static void generateSecondTestFileOutput(string[] testFileContents)
        {
            List<ElfPairs> elfList = new List<ElfPairs>();
            foreach (var item in testFileContents)
            {
                elfList.Add(new ElfPairs(item));
            }
            Console.WriteLine($"There was {getRangeContainedElfCount(elfList)} range contained pair(s)");
        }

        private static int getSelfContainedElfCount(List<ElfPairs> elfPairs)
        {
            return (from elf in elfPairs 
                where elf.checkIfFullyContained()
                select elf).Count();
        }

        private static int getRangeContainedElfCount(List<ElfPairs> elfPairs)
        {
            return (from elf in elfPairs 
                where elf.checkIfRangeContained()
                select elf).Count();
        }
    }
}
