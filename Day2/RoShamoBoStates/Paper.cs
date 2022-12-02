namespace Day2
{
    class Paper : PlayerHandShape
    {
        public override string GetHandShape()
        {
            return "Paper";
        }

        public override int GetOutCome(CompetitorHandShape competitorHandShape)
        {
            if (competitorHandShape == CompetitorHandShape.Rock)
            {
                return WinValue + GetShapeScore();
            }
            else if (competitorHandShape == CompetitorHandShape.Paper)
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
            return 2;
        }
    }
}