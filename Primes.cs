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
			int sqrt = (int)Math.Sqrt(number);
		
			for(int i = 1; i <= sqrt; i++)
			{
				if(number % i == 0 && i != 1 && i != number)
				{
					return false;
				}
			}
			return true;
		}
	}
}
