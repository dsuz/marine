using System;

public class Program
{
	public static void Main()
	{
		var line = Console.ReadLine();
		var n = int.Parse(line);
		
		if (n % 15 == 0)
		{
			Console.WriteLine("FizzBuzz");
		}
		else if (n % 3 == 0)
		{
			Console.WriteLine("Fizz");
		}
		else if (n % 5 == 0)
		{
			Console.WriteLine("Buzz");
		}
		else
		{
			Console.WriteLine(line);
		}
	}
}