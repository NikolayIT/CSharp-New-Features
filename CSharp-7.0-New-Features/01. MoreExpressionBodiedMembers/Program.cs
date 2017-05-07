using System;

public static class Program
{
    public static void Main()
    {
        using (var resource = new Resource())
        {
            resource.ToStringCalledEvent += (sender, args)
                => Console.WriteLine("ToString() called event handled.");
            resource.X = 1;
            Console.WriteLine(resource);
        }

        Console.WriteLine("Resource is no longer needed.");
    }
}
