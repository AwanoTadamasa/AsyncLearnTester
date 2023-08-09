namespace ConsoleApp1;

internal class AsyncTest
{
    public static void RUN()
    {
        int r = 0;
        var num = Task<int>.Run(() => SpinStick(r));

        while (true)
        {
            if (num.IsCompletedSuccessfully)
            {
                num = Task<int>.Run(() => SpinStick(r + 1));
            }
            Console.Write($"{stick[r]}\r");
        }
    }

    private static async Task SomeTask(int x)
    {
        Console.WriteLine($"Start Task{x}");
        await Task.Delay(1000 * x);
        Console.WriteLine($"End Task{x}");
    }

    private static async Task<int> SpinStick(int i)
    {
        await Task.Delay(50);
        return i++ % 4;
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
