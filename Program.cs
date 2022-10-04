using System;

namespace ProgramToPrintAllPrimeNumbers
{
	public class Program
	{
		public static void Main(string[]args)
		{
			int num1, num2, sayac = 0;
			Console.Write("Enter lower range: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter upper range: ");
			num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"Prime numbers between {num1} and {num2} are: ");
			Console.WriteLine("================================================");
			for (int i = num1; i < num2; i++)
			{
				sayac = 0;
				if(i>1)
				{
					for (int j = 2; j < i; j++)
					{
						if(i%j==0)
						{
							sayac = 1;
							break;
						}
					}
					if(sayac==0)
					{
						Console.WriteLine(i);
					}

				}
			}
            Console.ReadKey();

        }
	}

}