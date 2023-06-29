using System.IO;
using System;
using System.Net.Http;

public class Program
{
    public static void Main()
    {
        string content = File.ReadAllText(@"C:\Users\Gerben\GitProjecten\per4\ProgPer4\ProgPer4\ProgPer4\SplitOpdracht\SplitOpdracht\stringsplit.txt");
        string[] keyvalue = content.Split(":");
        foreach(string key in keyvalue)
        {
            Console.WriteLine(key);
        }
    }
}