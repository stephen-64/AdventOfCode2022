namespace Day4
{
    struct ElfTasks
    {
        public ElfTasks(int taskRangeStart, int taskRangeEnd)
        {
            this.taskRangeStart = taskRangeStart;
            this.taskRangeEnd = taskRangeEnd;
        }

        int taskRangeStart {get;}

        int taskRangeEnd {get;}

        public Boolean checkRangeFullyContained(ElfTasks otherElfTasks)
        {
            return this.taskRangeStart <= otherElfTasks.taskRangeStart && this.taskRangeEnd >= otherElfTasks.taskRangeEnd;
        }

        public Boolean checkRangeContained(ElfTasks otherElfTasks)
        {
            bool isThisElfFirstTask = this.taskRangeStart <= otherElfTasks.taskRangeStart;
            return this.taskRangeStart <= otherElfTasks.taskRangeStart && this.taskRangeEnd >= otherElfTasks.taskRangeEnd
                || otherElfTasks.taskRangeStart <= this.taskRangeStart && otherElfTasks.taskRangeEnd >= this.taskRangeEnd
                || (isThisElfFirstTask ? this.taskRangeEnd >= otherElfTasks.taskRangeStart : otherElfTasks.taskRangeEnd >= this.taskRangeStart);
        }
    }

    class ElfPairs
    {
        ElfTasks firstElf {get;}

        ElfTasks secondElf {get;}

        public ElfPairs(string elfTasksToParse)
        {
            string[] elfs = elfTasksToParse.Split(",");
            string[] elfsTasks = elfs[0].Split("-");
            firstElf = new ElfTasks(int.Parse(elfsTasks[0]), int.Parse(elfsTasks[1]));
            elfsTasks = elfs[1].Split("-");
            secondElf = new ElfTasks(int.Parse(elfsTasks[0]), int.Parse(elfsTasks[1]));
        }

        public bool checkIfFullyContained()
        {
            return firstElf.checkRangeFullyContained(secondElf) || secondElf.checkRangeFullyContained(firstElf);
        }

        public bool checkIfRangeContained()
        {
            return firstElf.checkRangeContained(secondElf);
        }
    }
}