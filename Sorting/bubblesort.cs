using System;
using System.Collections.Generic;
using System.Linq;

class BubbleSort {
    static void Main() {
        int[] a= new []{99,44,6,2,1,5,63,87,283,4,0};
        for(int i = 0 ; i < a.Length;i++)
        {
            for(int j = 0 ; j < a.Length-1;j++)
        {
            if(a[j] >a[j+1])
            {
                a[j] =a[j] + a[j+1];
                a[j+1] = a[j]-a[j+1];
                a[j]=a[j]-a[j+1];
            }
        }
        }
        
         for(int i = 0 ; i < a.Length;i++)
        {
            Console.WriteLine(a[i]);
        }
        
    }
}
