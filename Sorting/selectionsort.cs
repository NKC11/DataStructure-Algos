using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort {
    static void Main() {
    int[] a= new []{99,44,6,2,1,5,63,87,283,4,0};
       int smallest= 0;
       
   for(int i = 0 ; i < a.Length;i++)
        {
            smallest = i;
            for(int j = i+1 ; j < a.Length;j++)
        {
            if(a[j] < a[smallest])
            {
                a[smallest] =a[smallest]+ a[j];
                a[j]= a[smallest] -a[j];
                a[smallest]=a[smallest]-a[j];
            }
        }
        }
        Console.WriteLine("Sorted Array");
         for(int i = 0 ; i < a.Length;i++)
        {
            Console.Write(a[i] +" ");
        }
        
    }
}
