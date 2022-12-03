namespace Day3
{
    class BagContentsPart2
    {
        public int score {get;} = 0;
        private const int LOWER_CASE_SUBTRACTION_FACTOR = 96;
        private const int UPPER_CASE_SUBTRACTION_FACTOR = 38;
        public BagContentsPart2(string bag1, string bag2, string bag3)
        {
            foreach (var item in bag1)
            {
                if(bag2.Contains(item))
                {
                    if (bag3.Contains(item))
                    {
                        if (item >= LOWER_CASE_SUBTRACTION_FACTOR)
                        {
                            score = (item - LOWER_CASE_SUBTRACTION_FACTOR);
                        }
                        else
                        {
                            score = (item - UPPER_CASE_SUBTRACTION_FACTOR);
                        }
                    }
                }
            }
        }
    }
}