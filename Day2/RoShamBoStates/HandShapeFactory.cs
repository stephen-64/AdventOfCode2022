namespace Day2
{
    public class HandShapeFactory
    {
        public static CompetitorHandShape GetCompetitorHandShape(string handShapeToAssign)
        {
            if("A".Equals(handShapeToAssign.ToUpper()))
            {
                return CompetitorHandShape.Rock;
            }
            else if("B".Equals(handShapeToAssign.ToUpper()))
            {
                return CompetitorHandShape.Paper;
            }
            else
            {
                return CompetitorHandShape.Scissors;
            }
        }

        public static PlayerHandShape GetPlayerHandShape(string handShapeToAssign)
        {
            if("X".Equals(handShapeToAssign.ToUpper()))
            {
                return new Rock();
            }
            else if("Y".Equals(handShapeToAssign.ToUpper()))
            {
                return new Paper();
            }
            else
            {
                return new Scissors();
            }
        }

        public static int GetScore(CompetitorHandShape competitorHandShape, string outcomeToSet)
        {
            if (competitorHandShape == CompetitorHandShape.Paper)
            {
                if ("X".Equals(outcomeToSet.ToUpper()))
                {
                    return new Rock().GetOutCome(competitorHandShape);
                }
                else if("Y".Equals(outcomeToSet.ToUpper()))
                {
                    return new Paper().GetOutCome(competitorHandShape);
                }
                else
                {
                    return new Scissors().GetOutCome(competitorHandShape);
                }
            }
            else if (competitorHandShape == CompetitorHandShape.Rock)
            {
                if ("X".Equals(outcomeToSet.ToUpper()))
                {
                    return new Scissors().GetOutCome(competitorHandShape);
                }
                else if("Y".Equals(outcomeToSet.ToUpper()))
                {
                    return new Rock().GetOutCome(competitorHandShape);
                }
                else
                {
                    return new Paper().GetOutCome(competitorHandShape);
                }
            }
            else
            {
                if ("X".Equals(outcomeToSet.ToUpper()))
                {
                    return new Paper().GetOutCome(competitorHandShape);
                }
                else if("Y".Equals(outcomeToSet.ToUpper()))
                {
                    return new Scissors().GetOutCome(competitorHandShape);
                }
                else
                {
                    return new Rock().GetOutCome(competitorHandShape);
                }
            }
        }
    }
}