namespace Day2
{
    class Rock : PlayerHandShape
    {
        public override string GetHandShape()
        {
            return "Rock";
        }

        public override int GetOutCome(CompetitorHandShape competitorHandShape)
        {
            if (competitorHandShape == CompetitorHandShape.Scissors)
            {
                return WinValue + GetShapeScore();
            }
            else if (competitorHandShape == CompetitorHandShape.Rock)
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
            return 1;
        }
    }
}