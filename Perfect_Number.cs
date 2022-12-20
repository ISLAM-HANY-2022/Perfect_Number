using System;
using System.Linq;

namespace Perfect_Number
{
	public static class Program
	{
		public static int FindFactors(int num2){
		int sum = 0;
		for(int i=1; i < num2; i++)
		{
			if(num2 % i ==0)
			{
				sum = sum + i;
			}
			
		}
		return sum;	
		}
		
		public static void Main()
		{
         Console.WriteLine("The Last Number :");
         int num2 = int.Parse(Console.ReadLine());
         Console.WriteLine("_________");
         Console.WriteLine("The Prfect Number Is :");
         for(int i=1; i <= num2; i++)
         {
         	int result = FindFactors(i);
         	 if(i == result)
         	 {
         	 	Console.WriteLine(""+i);
         	 }
         }
		
			
		}
	}
}