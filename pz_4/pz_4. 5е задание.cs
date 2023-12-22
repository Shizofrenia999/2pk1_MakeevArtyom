using System;

class Program
{
	static void Main()
	{
		int i = 3;
		int j = 50;
		int razli4ia = 17;
		while (Math.Abs(i - j) >= razli4ia)
		{
			Console.WriteLine("i = " + i + ", j = " + j);
			i++;
			j--;
		}
	}
}