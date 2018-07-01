using System;

namespace screenkeeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Keeping the screen alive...");
            Console.WriteLine("Press any key to stop");
            SleepPreventer.PreventSleep();
            try
            {
                Console.ReadKey();
            }
            finally
            {
                SleepPreventer.EnableSleep();
            }
        }
    }
}
