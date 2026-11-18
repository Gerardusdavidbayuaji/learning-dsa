namespace DSA.Problems.Easy.Sorting;

public class InsertionSort1
{
    public static void InsertionSort(int n, List<int> arr)
    {
        int key = arr[n - 1];
        int j = n - 2;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        
        arr[j + 1] = key;
    }
}

