using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab1;

class Zadanie7
{
    public void Process()
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Array befor sort:");
        PrintArray(array);

        BubbleSortAlgorithm(array);

        Console.WriteLine("\nArray after sort:");
        PrintArray(array);
    }

    private void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    private void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
