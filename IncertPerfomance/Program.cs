//Наша задача — сравнить производительность вставки в List<T> и LinkedList<T>.Для этого используйте уже знакомый вам StopWatch.
//На примере этого текста, выясните, какие будут различия между этими коллекциями.
using System.IO;
using System.Threading;

string path = @"C:\Users\Fail\Desktop\Modul\IncertPerfomance\Text1.txt";
FileInfo fileInfo = new FileInfo(path);
string contents = File.ReadAllText(@"C:\Users\Fail\Desktop\Modul\IncertPerfomance\Text1.txt");

if (fileInfo.Exists)
{

    Console.WriteLine($"Имя файла: {fileInfo.Name}");
    Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
    Console.WriteLine($"Размер: {fileInfo.Length}");

    string s = "";
    string[] textMass;
    StreamReader sr = new StreamReader(path);
    while (sr.EndOfStream != true)
    {
        s += sr.ReadLine();
    }
    textMass = s.Split(' ');
    Console.WriteLine(textMass.Length);


}