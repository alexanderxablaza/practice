using System;
using System.Collections.Generic;
namespace App
{
	class Program
	{
		
		public static void Main(String[] a)
		{
			string inp = "CADABA";
			Dictionary<char,uint> charCount = new Dictionary<char, uint>(inp.Length);
			for(int i = 0; i < inp.Length; i++)
			{
				char x = inp.ToUpper()[i];
				if(charCount.ContainsKey(x))
				{
					charCount[x] += 1;
				}
				else
				{
					charCount.Add(x,1);
				}
			}
			foreach(KeyValuePair<char, uint> i in charCount)
			{
				if(i.Value > 1)
				Console.Write("{0} appears {1} times.", i.Key, i.Value);
			}
		}
	};
}
