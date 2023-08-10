namespace ConsoleApp1;

internal class AsyncTest
{
    public static void RUN()
    {
        int spinStick = 0;
        int i = 0;
        var num = TimerByMilliSecond(100);
        var obj = new object();

        while (true)
        {
            if (num.Status == TaskStatus.RanToCompletion)
            {
                lock (obj)
                {
                    Console.Write("stick");
                    spinStick = (spinStick + 1) % 4; 
                    num = TimerByMilliSecond(100);
                }
            }

            i = (i + 1) % 1000;
            Console.Write("{0,2}{1,4}\r", stick[spinStick], i);
        }
    }

    private static async Task SomeTask(int x)
    {
        Console.WriteLine($"Start Task{x}");
        await Task.Delay(1000 * x);
        Console.WriteLine($"End Task{x}");
    }

    private static async Task TimerByMilliSecond(int i)
    {
        await Task.Delay(i);
    }

    private static readonly Dictionary<int, string> stick = new()
    {
        {0,@"｜" },
        {1,@"／" },
        {2,@"ー" },
        {3,@"＼" }
    };
    //Task*()
    //Console.WriteLine("TUGI");


    //private static async Task<int> task()
    //{
    //    Console.WriteLine("KAISI");


    //    File.ReadAllBytesAsync
    //    File.ReadAllBytesAsync



    //    return 1;
    //}
}
