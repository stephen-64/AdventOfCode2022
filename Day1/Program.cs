namespace Day1
{
    class Program
        {
            static void Main(string[] args)
            {
                string[] elfCountArray = System.IO.File.ReadAllLines("input.txt");
                List<Elf> elfList = new List<Elf>();
                Elf currentElf = new Elf();
                foreach (var elf in elfCountArray)
                {
                    if (elf.Length != 0)
                    {
                        currentElf.addCalories(Int64.Parse(elf));
                    }
                    else
                    {
                        elfList.Add(currentElf);
                        currentElf = new Elf();
                    }
                }
                elfList.Sort(delegate(Elf elf1, Elf elf2){
                    return elf1.calories.CompareTo(elf2.calories);
                });
                elfList.Reverse();
                Console.WriteLine($"We had {elfList.Count} Elf's and the max calories was {elfList[0].calories}");
                Console.WriteLine($"The top 3 Elfs were carrying a combined total of {elfList[0].calories + elfList[1].calories + elfList[2].calories}");
            }
        }
}
