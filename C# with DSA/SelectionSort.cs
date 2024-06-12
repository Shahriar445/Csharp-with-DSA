using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__with_DSA
{
    public  class SelectionSort
    {
        public SelectionSort() {

            int[] arr = { 7, 5, 9, 2, 8 };
            int n = arr.Length;
            int mini = 0;
            int i = 0;
            for (i = 0; i<n-1; i++)
            {
                 mini = i;

                for (int j = i+1; j<n; j++)
                {
                    if (arr[j] < arr[mini])
                    {
                        mini= j;
                    }
                }
                int temp = arr[mini];
                arr[mini]= arr[i];
                arr[i]= temp;
            }
           

            Console.WriteLine("Sorted Array");
            for ( i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]+ " "); 
            }

            
        
        
        }

    }
}
