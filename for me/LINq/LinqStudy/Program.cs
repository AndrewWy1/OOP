namespace LinqStudy;

public class Program
{
    static void Main(string[] args)
    {
        Task task1 = new Task(() => 
        {
            Console.WriteLine($"Task{Task.CurrentId} s");
            Thread.Sleep(1000);
            Console.WriteLine($"Task{Task.CurrentId} e");
        });

        task1.Start();
        Console.WriteLine($"Task id:{task1.Id}");
        Console.WriteLine($"Task is Completed:{task1.IsCompleted}");
        Console.WriteLine($"Task Status:{task1.Status}");

        task1.Wait();
    }
}