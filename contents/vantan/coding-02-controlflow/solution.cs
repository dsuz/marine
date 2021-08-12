using System;

public class Program
{
	public static void Main()
	{
		var line = Console.ReadLine();
		var nums = line.Split(' ');
		int min = int.MaxValue;
		float avg = 0f;
		
		foreach (var num in nums)
		{
			int i = int.Parse(num);
			avg += i;
			
			if (i < min)
			{
				min = i;
			}
		}
		
		avg /= nums.Length;
		Console.WriteLine(min);
		Console.WriteLine(avg.ToString("F2"));
	}
}
