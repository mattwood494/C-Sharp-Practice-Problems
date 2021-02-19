using System;

namespace Mock_Interview_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

			int sum = OddSum(3);
            Console.WriteLine(sum);
        }

		static int OddSum(int amount)
		{
			int sum = 0;
			int counter = 0;
			int i = 0;


			while (counter < amount)
			{
				if (i % 2 == 1)
				{
					sum = sum + i;
					counter++;
				}
				i++;
			}

			return sum;
		}
	}
}
