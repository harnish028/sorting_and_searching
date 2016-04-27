public static class DHeapS
{
    public static void HeapSort(int[] arr, int d)
    {
        int heapSize = arr.Length - 1;
        BuildHeap(arr, d); 
        for (int i = arr.Length - 1; i >= 1; i--)
        {
            int temp = arr[0]; 
            arr[0] = arr[i];
            arr[i] = temp;
            heapSize--;
            Heapify(arr, 0, heapSize, d);
        }
    }

    static void BuildHeap(int[] arr, int d)
    { 
        for (int i = (arr.Length -1) / d; i >= 0; i--)
        {
            Heapify(arr, i, arr.Length - 1, d);
        }
    }

    //i - parent; j - childNumber
    static void Heapify(int[] arr, int i, int heapSize, int d)
    { 
        int largest;
        for (int j = 1; j <= d; j++)
        {
            int child = GetChild(d, i, j);
            if (child <= heapSize && arr[child] > arr[i])
                largest = child;
            else
                largest = i;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                Heapify(arr, largest, heapSize, d);
            }
        }
    }

    static int GetChild(int d, int parent, int childNumber)
    {
        return d * parent + childNumber;
    }
}
