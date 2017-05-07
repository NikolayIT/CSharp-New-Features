using System;

public class Resource : IDisposable
{
    private int x;
    private EventHandler toStringCalledEventHandler;

    // C# 7.0 - Constructor
    public Resource() => Console.WriteLine($"Constructing {nameof(Resource)}...");

    // C# 7.0 - Destructor
    ~Resource() => Console.WriteLine("Destructing...");

    // C# 7.0 - Event accessors
    public event EventHandler ToStringCalledEvent
    {
        add => this.toStringCalledEventHandler += value;
        remove => this.toStringCalledEventHandler -= value;
    }

    // C# 6.0 - Get-accessor only property
    public int Y => 42;

    // C# 7.0 - Property accessors
    public int X
    {
        get => this.x;
        set => this.x = value;
    }

    // C# 6.0 - Method
    public void Dispose() => Console.WriteLine("Disposing...");

    public override string ToString()
    {
        this.toStringCalledEventHandler(this, EventArgs.Empty);
        return $"({this.X}, {this.Y})";
    }
}
