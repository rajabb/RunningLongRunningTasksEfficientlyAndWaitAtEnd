namespace RunningLongRunningTasksEfficientlyAndWaitAtEnd;

public class LongRunningTask
{
    public static async Task RunAsync(string input)
    {
        Random rnd = new Random();
        await Task.Delay(rnd.Next(1000,10000));
        Console.WriteLine($"Task {input} Done.");
    }
}

