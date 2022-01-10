using System.Runtime.CompilerServices;

namespace Exploring.Thread;

public class Test
{
    private readonly Resource _res = new Resource();

    private static void Main(string[] args)
    {
        System.Threading.Thread.CurrentThread.Name = "Main";
        Test test = new Test();
        var worker = new System.Threading.Thread(test.ThreadEntry)
        {
            Name = "Worker"
        };
        worker.Start();
        test.ThreadEntry();
    }

    public void ThreadEntry()
    {
        //Monitor.Enter(_res);
        //_res.Record();
        //Monitor.Exit(_res);
        lock (_res)
        {
            try
            {
                _res.Record();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

public class Resource
{
    public string? Called;

    //[MethodImpl(MethodImplOptions.Synchronized)]
    public void Record()
    {
        this.Called += $"{System.Threading.Thread.CurrentThread.Name}[{DateTime.Now.Millisecond}] ";
        Console.WriteLine(Called);
    }
}