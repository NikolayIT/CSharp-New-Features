namespace _10.AwaitInCatchFinally
{
    using System;
    using System.IO;

    internal class Program
    {
        internal static void Main()
        {
            ReadData(@"..\..\Program.cs", @"Log.txt");
            Console.ReadLine();
        }

        private static async void ReadData(string fileName, string logFileName)
        {
            var input = new StreamReader(fileName);
            var log = new StreamWriter(logFileName);
            try
            {
                var line = await input.ReadLineAsync();
                Console.WriteLine("Line written");
            }
            catch (IOException ex)
            {
                await log.WriteLineAsync(ex.ToString());
                Console.WriteLine("Log written");
            }
            finally
            {
                if (log != null) await log.FlushAsync();
                Console.WriteLine("Log flushed");
            }
        }
    }
}
