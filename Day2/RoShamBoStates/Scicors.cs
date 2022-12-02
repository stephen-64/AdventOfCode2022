namespace Day2
{
    class Scissors : PlayerHandShape
    {
        public override string GetHandShape()
        {
            return "Scissors";
        }

        public override int GetOutCome(CompetitorHandShape competitorHandShape)
        {
            if (competitorHandShape == CompetitorHandShape.Paper)
            {
                return WinValue + GetShapeScore();
            }
            else if (competitorHandShape == CompetitorHandShape.Scissors)
            {
                return DrawValue + GetShapeScore();
            }
            else
            {
                return LoseValue + GetShapeScore();
            }
        }
        
        protected override int GetShapeScore()
        {
            return 3;
        }
    }
}