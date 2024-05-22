public class Program
{
    public static async Task Main(string[] args)
    {
        await FirstOperation();
        await SecondOperation();
        await ThirdOperation();

        var FirstTask = FirstOperation();
        var SecondTask = SecondOperation();
        var ThirdTask = ThirdOperation();
            
        await Task.WhenAll(FirstTask, SecondTask, ThirdTask);
        //another task
    }
    public static async Task FirstOperation()
    {
        Console.WriteLine("First Operation Done!");
    }

    public static async Task SecondOperation()
    {
        Console.WriteLine("Second Operation Done!");
    }

    public static async Task ThirdOperation()
    {
        Console.WriteLine("Third Operation Done!");
    }
}