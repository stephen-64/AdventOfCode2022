namespace Day3
{
    class BagContents
    {
        public string firstHalf {get;}
        public string secondHalf {get;}

        public int score {get;} = 0;
        private const int LOWER_CASE_SUBTRACTION_FACTOR = 96;
        private const int UPPER_CASE_SUBTRACTION_FACTOR = 38;
        public BagContents(string contents)
        {
            int halfOfContents = contents.Length/2;
            firstHalf = contents.Substring(0, halfOfContents);
            secondHalf = contents.Substring(halfOfContents, halfOfContents);
            foreach (var item in firstHalf)
            {
                if (secondHalf.Contains(item))
                {
                    if(item >= LOWER_CASE_SUBTRACTION_FACTOR)
                    {
                        score = item - LOWER_CASE_SUBTRACTION_FACTOR;
                    }
                    else
                    {
                        score = item - UPPER_CASE_SUBTRACTION_FACTOR;
                    }
                    break;
                }
            }
        }
    }
}