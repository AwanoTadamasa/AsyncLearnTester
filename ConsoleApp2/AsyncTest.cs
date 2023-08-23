using System.Windows.Input;

namespace ConsoleApp2;

internal class AsyncTest
{
    int r = 0;
    public void RunRoop()
    {
        var i = 0;
        var spin = Task.Run(SpinStick);

        while (true)
        {
            i = (i + 1) % 1000;
            if (spin.Status == TaskStatus.RanToCompletion) spin = Task.Run(SpinStick);
            Console.Write("{0,2}{1,4}\r", stick[r], i);
            if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                break;
            }
        }
    }

    private async Task SpinStick()
    {

        await Task.Delay(100);
        r = (r + 1) % 4;

    }

    private readonly Dictionary<int, string> stick = new()
    {
        {0, "｜" },
        {1, "／" },
        {2, "―" },
        {3, "＼" }
    };
}
