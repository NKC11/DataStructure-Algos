using System;

class Program {
  public static void Main (string[] args) {
   Console.WriteLine("Enter the input");
    var inputString= Console.ReadLine();

char[] arr= new char[inputString.Length];

int index = inputString.Length-1;
for (int i=0; i<inputString.Length;i++)
{
  arr[i]=inputString[index];
  index--;
}
Console.WriteLine("Reverse of the entered String is");
// foreach(char c in arr)
// {
//   Console.Write(c);
// }

Console.WriteLine(String.Join("",arr));
  }
}
