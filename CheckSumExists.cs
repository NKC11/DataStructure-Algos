using System;
using System.Collections.Generic;

					
public class CheckSumExists
{
	public static void Main()
	{
		int sum = 8;
		float[] arr = new float[] {1.2F,3.3F,2.3F,5.0F,6.8F};
		Console.Write("Result is : " + checkSumExists(arr, sum));
	}
	private static bool checkSumExists(float[] inputArray, int sum)
	{
		List<float> diffArray= new List<float>();
		for (int i= 0 ;i< inputArray.Length; i++)
		{
			if(diffArray.Contains((inputArray[i])))
			{
			return true;	
			}
			else
			{
				if(sum>inputArray[i])
			diffArray.Add(sum-inputArray[i]);
				else
			diffArray.Add(inputArray[i]-sum);
			}
			
			
		}
		
		return false;
	}
}
