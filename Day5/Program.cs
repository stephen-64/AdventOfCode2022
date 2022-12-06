namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testinput = File.ReadAllLines("testinput.txt");
            string topOfStack = generateTopOfStackOutput(testinput, false);
            Console.WriteLine($"The top of the stack will contain: {topOfStack}");
            string[] inputDay5 = File.ReadAllLines("input.txt");
            topOfStack = generateTopOfStackOutput(inputDay5, false);
            Console.WriteLine($"The top of the first problem stack is: {topOfStack}");
            string topOfStack2 = generateTopOfStackOutput(testinput, true);
            Console.WriteLine($"The top of the test stack in problem 2 is: {topOfStack2}");
            topOfStack2 = generateTopOfStackOutput(inputDay5, true);
            Console.WriteLine($"The top of the seconds problem stack is: {topOfStack2}");
        }

        private static string generateTopOfStackOutput(string[] inputToProcess, bool mulipleMoves)
        {
            List<string> stackstoSetup = new List<string>();
            List<string> instructions = new List<string>();
            bool stackSetupDone = false;
            foreach (var inputString in inputToProcess)
            {
                if (!stackSetupDone)
                {
                    if(inputString.Trim().Length == 0)
                    {
                        stackSetupDone = true;
                        continue;
                    }
                    stackstoSetup.Add(inputString);
                }
                else
                {
                    instructions.Add(inputString);
                }
            }
            stackstoSetup.Reverse();
            StackHolder stackHolder = new StackHolder(stackstoSetup.ToArray());
            stackHolder.moveListToProcess(instructions.ToArray(), mulipleMoves);
            return stackHolder.topOfStack();
        }
    }
}
