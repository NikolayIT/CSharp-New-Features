using System;

public class Point : ICloneable
{
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public int X { get; set; }

    public int Y { get; set; }

    public void Print() => Console.WriteLine(this.X + " " + this.Y);

    public object Clone() => new Point(this.X, this.Y);

    public void Move(int x, int y)
    {
        this.X += x;
        this.Y += y;
    }
}
