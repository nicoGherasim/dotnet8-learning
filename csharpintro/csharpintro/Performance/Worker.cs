namespace csharpintro.Performance
{
    public static class Worker
    {
        public static void CountAscending()
        {
            for(int i = 0;  i <= 10; i++)
            {
                Console.WriteLine("t1: " + i);
                Thread.Sleep(100);
            }
        }

        public static void CountDescending()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("t2: " + i);
                Thread.Sleep(200);
            }
        }
    }
}
