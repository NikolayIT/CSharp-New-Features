using System;

public static class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("ExceptionFilter");
        Console.ResetColor();
        ExceptionFilter();

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("ExceptionFilterWithLogging");
        Console.ResetColor();
        try
        {
            ExceptionFilterWithLogging.Demo();
        }
        catch (Exception ex)
        {
            Console.WriteLine("======== Stack trace from Main() ========");
            Console.WriteLine(ex.StackTrace);
        }
    }

    private static void ExceptionFilter()
    {
        Person person = null;
        try
        {
            string firstName = "Nikolay";
            string lastName = null;
            person = new Person(firstName, lastName);
        }
        catch (ArgumentNullException ex) when (ex.ParamName == "firstName")
        {
            Console.WriteLine("First name is null");
        }
        catch (ArgumentNullException ex) when (ex.ParamName == "lastName")
        {
            Console.WriteLine("Last name is null");
        }

        if (person != null)
        {
            Console.WriteLine(person.Name);
        }
    }
}
