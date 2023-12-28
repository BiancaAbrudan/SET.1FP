internal static class ProgramHelpers
{

    private static int CountLeapYears(int y1, int y2)
    {
        int count = 0;
        for (int y = y1; y <= y2; y++)
        {
            if ((y % 4 == 0) && (y % 100 != 0) || (y % 400 == 0))
            {
                count++;
            }
        }
        return count;
    }
}