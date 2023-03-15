//Наша задача — сравнить производительность вставки в List<T> и LinkedList<T>.Для этого используйте уже знакомый вам StopWatch.
//На примере этого текста, выясните, какие будут различия между этими коллекциями.
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;

TestTimeWorkList();
TestTimeWorkLinkedList();

static void TestTimeWorkList()
{
    string path = @"C:\Users\Fail\Desktop\Modul\IncertPerfomance\Text1.txt";
    FileInfo fileInfo = new FileInfo(path);
    if (fileInfo.Exists)
    {
        Console.WriteLine(fileInfo.Name);
        var timer = new Stopwatch();
        timer.Start();
        var contents = File.ReadAllText(@"C:\Users\Fail\Desktop\Modul\IncertPerfomance\Text1.txt");
        var contentList = new List<string>();
        contentList.Add(contents);
        timer.Stop();
        Console.WriteLine($"Time work in millisecond for List: {timer.ElapsedMilliseconds}");
    }
}
static void TestTimeWorkLinkedList()
{
    string path = @"C:\Users\Fail\Desktop\Modul\IncertPerfomance\Text1.txt";
    FileInfo fileInfo = new FileInfo(path);
    if (fileInfo.Exists)
    {
        var timer = new Stopwatch();
        timer.Start();
        var contents = File.ReadAllText(@"C:\Users\Fail\Desktop\Modul\IncertPerfomance\Text1.txt");
        var contentList = new List<string>();
        LinkedList<string> Llist = new LinkedList<string>(contentList);
        timer.Stop();
        Console.WriteLine($"Time work in millisecond for LinkedList: {timer.ElapsedMilliseconds}");
    }
}