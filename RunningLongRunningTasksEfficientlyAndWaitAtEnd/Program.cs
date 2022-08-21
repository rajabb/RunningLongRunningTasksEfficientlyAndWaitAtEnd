using RunningLongRunningTasksEfficientlyAndWaitAtEnd;

 Console.WriteLine("Running Task");

 List<Task> tasks = new List<Task>();

 for (int i = 0; i < 100; i++)
 {
      tasks.Add(LongRunningTask.RunAsync(i.ToString()));
 }

 await Task.WhenAll(tasks.ToArray());

 Console.WriteLine("Approach 1 Done");

