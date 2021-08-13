using System;

public class Program
{
	public static void Main()
	{
		var line = Console.ReadLine();
		var n = int.Parse(line);
		Console.WriteLine(Fibonacci(n));
	}
	
	static int Fibonacci(int n)
	{
		if (n == 0)
		{
			return 0;
		}
		else if (n == 1)
		{
			return 1;
		}
		else
		{
			return Fibonacci(n - 1) + Fibonacci(n - 2);
		}
	}
}