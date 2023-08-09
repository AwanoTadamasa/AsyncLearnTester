namespace ConsoleApp1;

internal class TrushedAsyncTest
{
    public static async Task Cal()
    {
        Console.WriteLine("Call Tests");
        var task1 = Task.Run(() => Task1());
        var task2 = Task.Run(() => Task2());

        var task3 = Task3Async();
        var task4 = Task4Async();

        var i = 0;

        while (!(task1.IsCompleted && task2.IsCompleted && task3.IsCompleted && task4.IsCompleted))
        {
            Console.Write($"{stick[i]}\r");
            i = (i + 1) % 4;
            await Task.Delay(50);
        }
        Console.WriteLine($"End Tests\r\n[\r\n\t{task1}\r\n\t{task2}\r\n\t{task3}\r\n\t{task4}\r\n]");
    }

    private static void Task1()
    {
        Console.WriteLine("Start Task1");
        Thread.Sleep(1000);
        Console.WriteLine("End Task1");
    }

    private static void Task2()
    {
        Console.WriteLine("Start Task2");
        Thread.Sleep(2000);
        Console.WriteLine("End Task2");
    }

    private static async Task Task3Async()
    {
        Console.WriteLine("Start Async Task 3");
        await Task.Delay(3000);
        Console.WriteLine("End Async Task 3");
        //await Task.Yield();
    }

    private static async Task Task4Async()
    {
        Console.WriteLine("Start Async Task 4");
        await Task.Delay(4000);
        Console.WriteLine("End Async Task 4");
        //await Task.Yield();
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
