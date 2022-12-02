namespace Day2
{
    public abstract class PlayerHandShape
    {
        protected int WinValue = 6;
        protected int DrawValue = 3;
        protected int LoseValue = 0;
        public abstract string GetHandShape();
        public abstract int GetOutCome(CompetitorHandShape competitorHandShape);
        protected abstract int GetShapeScore();
    }
}