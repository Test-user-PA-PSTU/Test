using System;

class Quick
{

    static int Partition(int[] arr, int low, int high)
    {


        int first = arr[high];

        int i = low - 1;

        for (int j = low; j <= high - 1; j++)
        {
            if (arr[j] < first)
            {
                i++;
                Swap(arr, i, j);
            }
        }

      
        Swap(arr, i + 1, high);
        return i + 1;
    }

  
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }


    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {


            int fi = Partition(arr, low, high);

     
            QuickSort(arr, low, fi - 1);
            QuickSort(arr, fi + 1, high);
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 10, 7, 8, 9, 1, 5 };
        int n = arr.Length;

        QuickSort(arr, 0, n - 1);
        foreach (int val in arr)
        {
            Console.Write(val + " ");
        }
    }
}
