using System;
using System.IO;

public static class Program
{
    public static void Main()
    {
        ReadData(@"..\..\Program.cs", @"Log.txt");
        ReadDataAsync(@"..\..\Program.cs", @"Log.txt");
        Console.ReadLine();
    }

    private static async void ReadDataAsync(string fileName, string logFileName)
    {
        // "using" statements omitted for simpler CIL code for the demo
        var input = new StreamReader(fileName);
        var log = new StreamWriter(logFileName);
        try
        {
            var line = await input.ReadLineAsync();
            Console.WriteLine("Line read");
        }
        catch (IOException ex)
        {
            await log.WriteLineAsync(ex.ToString());
            Console.WriteLine("Log written");
        }
        finally
        {
            await log.FlushAsync();
            Console.WriteLine("Log flushed");
        }
    }

    private static void ReadData(string fileName, string logFileName)
    {
        // "using" statements omitted for simpler CIL code for the demo
        var input = new StreamReader(fileName);
        var log = new StreamWriter(logFileName);
        try
        {
            var line = input.ReadLineAsync();
            Console.WriteLine("Line read");
        }
        catch (IOException ex)
        {
            log.WriteLine(ex.ToString());
            Console.WriteLine("Log written");
        }
        finally
        {
            log.Flush();
            Console.WriteLine("Log flushed");
        }
    }
}
