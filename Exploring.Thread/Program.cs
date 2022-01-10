//using Exploring.Thread;

//var ts = new ThreadStart(ThreadEntry);
//var worker = new Thread(ts);
//Thread.CurrentThread.Name = "Main";
//Console.WriteLine(Thread.CurrentThread.Name);
//worker.Start();

//var tsWithParam = new ParameterizedThreadStart(ThreadEntryWithParam);
//string[] obj = {"item9", "item10"};
//var workerWithParameter = new Thread(tsWithParam); 
//workerWithParameter.Start(obj);
//Console.WriteLine("Main Thread ends");
//Console.ReadKey();

//static void ThreadEntry()
//{
//    Thread.CurrentThread.Name = "Thread1";
//    var resource = new SharedResource();
//    resource.Add("Item5");
//}

//static void ThreadEntryWithParam(object? obj)
//{
//    Thread.CurrentThread.Name = "Thread2";
//    obj ??= new string[] {"item9", "item10"};
//    var resource = new SharedResource();
//    string[] items = (string[])obj;
//    foreach (var item in items)
//    {
//        resource.Add(item);
//    }
//}