using System;

public class Program
{
	public static void Main()
	{
		var line = Console.ReadLine();
		var n = int.Parse(line);
		
		if (IsPrime(n))
		{
			Console.WriteLine("素数");
		}
		else
		{
			Console.WriteLine("素数ではない");
		}
	}
	
	static bool IsPrime(int n)
	{
		if (n == 1)
		{
			return false;
		}
		else if (n == 2)
		{
			return true;
		}
		else if (n % 2 == 0)
		{
			return false;
		}
		else
		{
			for (int i = 3; i * i <= n; i += 2)
			{
				if (n % i == 0)
				{
					return false;
				}
			}
			
			return true;
		}
	}
}