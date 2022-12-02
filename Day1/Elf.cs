namespace Day1
{
    class Elf
    {
        public long calories {get; set;} = 0 ;
        public void addCalories(long caloriesCount)
        {
            calories += caloriesCount;
        }
    }
}