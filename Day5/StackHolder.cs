using System.Text.RegularExpressions;

namespace Day5
{
    class StackHolder
    {
        private static string stackFinderRegex {get;} = @"([A-Za-z])|([1-9]+)|(\x20{4})";

        private static Regex compiledStackFinderRegex {get;} = new Regex(stackFinderRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private static string moveExtractionRegex {get;} =@"move|from|to";

        private static Regex compiledMoveExtractionRegex {get;} = new Regex(moveExtractionRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public Dictionary<int, Stack<char>> stacksOfCrates {get;} = new Dictionary<int, Stack<char>>();

        private Stack<char> tempStack = new Stack<char>();

        public StackHolder(string[] cratesToSort)
        {
            int stackTracker = 0;
            MatchCollection matches = compiledStackFinderRegex.Matches(cratesToSort[stackTracker]);
            foreach (Match stack in matches)
            {
                stacksOfCrates.Add(int.Parse(stack.Value), new Stack<char>());
            }
            stackTracker++;
            int sizeOfStacks = cratesToSort.Count();
            while (stackTracker < sizeOfStacks)
            {
                matches = compiledStackFinderRegex.Matches(cratesToSort[stackTracker]);
                for (int stackPile = 0; stackPile < matches.Count(); stackPile++)
                {
                    if (matches[stackPile].Value.Trim().Length != 0)
                    {
                        stacksOfCrates[stackPile+1].Push(char.Parse(matches[stackPile].Value));
                    }
                }
                stackTracker++;
            }
        }

        private void moveInstructions(string moveToMake)
        {
            string [] moveSet = compiledMoveExtractionRegex.Split(moveToMake);
            for (int numberToMove = 0; numberToMove < int.Parse(moveSet[1].Trim()); numberToMove++)
            {
                var itemToMove = this.stacksOfCrates[int.Parse(moveSet[2])].Pop();
                this.stacksOfCrates[int.Parse(moveSet[3])].Push(itemToMove);
            }
        }

        private void moveMultipleInstructions(string moveToMake)
        {
            string [] moveSet = compiledMoveExtractionRegex.Split(moveToMake);
            for (int numberToMove = 0; numberToMove < int.Parse(moveSet[1].Trim()); numberToMove++)
            {
                tempStack.Push(this.stacksOfCrates[int.Parse(moveSet[2])].Pop());
            }
            while (tempStack.Count() > 0)
            {
                this.stacksOfCrates[int.Parse(moveSet[3])].Push(tempStack.Pop());   
            }
        }

        public void moveListToProcess(string[] movesToMake, bool moveMultiple)
        {
            foreach (var move in movesToMake)
            {
                if (moveMultiple)
                {
                    this.moveMultipleInstructions(move);
                }
                else
                {
                    this.moveInstructions(move);
                }
            }
        }

        public string topOfStack()
        {
            string topOfStackString = "";
            foreach (var itemAtTopOfStack in stacksOfCrates.Values)
            {
                topOfStackString += itemAtTopOfStack.Peek();
            }
            return topOfStackString;
        }
    }
}