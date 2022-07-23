using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Program
{
	public void Test()
	{
		IEnumerable<int> nM = Console.ReadLine().Split().Select(x => int.Parse(x));
		int l = nM.ElementAt(0);
		int r = nM.ElementAt(1);
        Console.WriteLine((l+r)/2);
	}

	public static void Main()
	{
		int T = int.Parse(Console.ReadLine());
		for (int test_no = 1; test_no < T + 1; test_no++)
		{
			//Test();
		}
	}
}
