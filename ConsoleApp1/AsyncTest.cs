using System.Diagnostics;

namespace ConsoleApp1;

internal class AsyncTest
{
    private static readonly Dictionary<int, string> Sticks = new()
    {
        { 0, @"｜" },
        { 1, @"／" },
        { 2, @"ー" },
        { 3, @"＼" }
    };

    private static int IncrementStick(int i)
    {
        var index = i % 4;
        var stick = Sticks[index];

        i = (i + 1) % 1000;
        Console.CursorLeft = 0;
        Console.Write($"Stick: {stick} {i:D4}");

        return i;
    }

    /// <summary>
    /// シーケンシャル実行。
    /// </summary>
    public void Run0()
    {
        var i = 0;
        while (true)
        {
            i = IncrementStick(i);
        }
    }

    /// <summary>
    /// ディレイ(重い処理)だけ分ける。
    /// </summary>
    public void Run1()
    {
        var i = 0;
        var task = Task.Delay(100);

        while (true)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine(" finish!");
                // ここでは待たないで処理される
                task = Task.Delay(100);
            }

            i = IncrementStick(i);
        }
    }

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
