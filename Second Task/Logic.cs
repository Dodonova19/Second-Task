namespace Second_Task
{
    public class Logic
    {
        public static long Solve(int n)
        {
            long i = 1;

            while (i * i <= n)
            {
                i++;
            }

            return i * i;
        }
    }
}
