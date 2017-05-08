using System;

public static class Program
{
    public static void Main()
    {
        byte n = 0b01001110; // 78 in decimal
        Console.WriteLine($"{nameof(n)} = {n}(10), {n:X}(16), {Convert.ToString(n, 2)}(2)");

        int bin = 0b1001_1010_0001_0100;
        int hex = 0x1b_a0_44_fe;
        int dec = 33_554_432;
        int weird = 1_2__3___4____5_____6______7_______8________9;
        double real = 1_000.111_1e-1_0;
        Console.WriteLine($"{nameof(bin)} = {bin}");
        Console.WriteLine($"{nameof(hex)} = {hex}");
        Console.WriteLine($"{nameof(dec)} = {dec}");
        Console.WriteLine($"{nameof(weird)} = {weird}");
        Console.WriteLine($"{nameof(real)} = {real}");
    }
}
