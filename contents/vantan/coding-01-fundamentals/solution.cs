using System;

public class Program
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] inputs = line.Split(' ');
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
    }
}
