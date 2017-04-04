using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write(findPrime(7919));
			Console.Read();
		}

		static bool findPrime(int number)
		{
			int k = 1;

			for(int i = 1; i <= (number / 2); i = i +2)
			{
				if (number % i == 0)
				{
					k++;
				}
			}
			if (k == 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}