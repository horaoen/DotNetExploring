namespace Exploring.Thread;

public class SharedResource
{
    public List<string> List = new List<string> {"Item1", "Item2", "Item3", "Item3"};

    public void Add(string item)
    {
        Console.WriteLine($"{System.Threading.Thread.CurrentThread.Name}: Add {item}");
        List.Add(item);
    }
}