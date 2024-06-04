using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C__with_DSA
{
    public class Binarry_Search_Recursive
    {
        public int BinarrySearch(int[] number, int low, int high, int target)
        {
            if (low> high) return -1; // base case

            int mid= (high+low)/2;

            if (number[mid]==target) return mid;
            else if (number[mid]< target)
            {
                return BinarrySearch(number, mid+1, high,target);
            }
            else
            {
              return   BinarrySearch(number,low,mid-1,target);
            }
              
         }

        int Searching(int[] number, int target)
        {
            // arr , lower element , upper element , target 
            return BinarrySearch(number, 0, number.Length-1, target);
        }


        public void Main_BS()
        {
            Console.WriteLine("Enter the size of Array: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter sorted  {size} of Array :");
            int[] arr = new int[size];
            for (int i =0;i<arr.Length;i++)
            {
               arr[i]= int.Parse(Console.ReadLine());  // Array input 
            }

            Console.WriteLine("Enter The Target");
            int target = int.Parse(Console.ReadLine()); // input target variable 
            int result = Searching(arr, target); // called the Searching recursion method 

            if (result == -1)
            {
                Console.WriteLine("Target Not Found");
            }
            else
            {
                Console.WriteLine("Target Found in index number: "+result);
            }

        }
    }
}
