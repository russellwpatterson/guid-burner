using System;
using System.Threading;

namespace GuidBurner
{
	class Program
	{
		static void Main(string[] args)
		{
			var count = 0L;

			while (true)
			{
				Console.WriteLine("{0}: {1}", ++count, Guid.NewGuid());
			}
		}
	}
}
