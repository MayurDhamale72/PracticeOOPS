using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPS
{
    internal class Sorting
    {
        public void BubbuleSort(int[] Arr)
        {
            int n = Arr.Length;
            for (int i = 0; i < n-1; i++) 
            { 
                for(int j = 0; j<n-i-1; j++)
                {
                    if(Arr[j] > Arr[j + 1])
                    {
                        int temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }
        }

        public void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0;i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i+1;j < n; j++)
                {
                    if(arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIdx];
                arr[minIdx] = temp;
            }
        }

        public void PrintArray(int[] Arr)
        {
            foreach(int i in Arr)
            {
                Console.WriteLine();
                Console.Write(i + "");
                
            }
        }

    }
}
