using System;
using System.Collections.Generic;
class Program {
  public static void Main (string[] args) {
  
int [] ip1 = new int [] {2,5,5,2,3,5,1,2,4};

//CheckFirstRepeatedItemUsingArray(ip1);
CheckFirstRepeatedItem(ip1);
  }

/*private static void CheckFirstRepeatedItemUsingArray(int[] input)
{
  bool hasRepItem = false;
  if(input==null || input.Length==0)
  {
  Console.WriteLine("undefined");
  }
 for (int i=0;i<input.Length;i++)
 {

    for (int j=0;j<input.Length;j++)
    {
      if(i!=j && input[i]==input[j])
      {
        hasRepItem= true;
        Console.WriteLine("First repeating element is : " + input[i]);
        return;
      }
    }    
 }
    if(!hasRepItem){
  Console.WriteLine("undefined");
  }
}

*/




private static void CheckFirstRepeatedItem(int[] input)
{
    bool hasRepItem = false;
  var dic = new Dictionary<int,int>();
  if(input==null || input.Length==0)
  {
  Console.WriteLine("undefined");
  }
 for (int i=0;i<input.Length;i++)
 {
    if (dic.ContainsKey(input[i]))
      {
        hasRepItem= true;
        Console.WriteLine("First repeating element is : " + input[i]);
        break;
      }
    else
      {
        dic.Add(input[i],0);
      }
  }
    if(!hasRepItem){
  Console.WriteLine("undefined");
  }
}
}
