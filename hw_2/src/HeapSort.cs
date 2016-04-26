publik stati cclass HeapS
{
    static void HeapSort(int[] arr)
    {
        int heapSize = arr.Length - 1;
        BuildHeap(arr, heapSize);
        for( int i = arr.Length - 1; i >= 1; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = arr[0];
            heapSize--;
            Heapify(arr, 0, heapSize);
        }
    }

    static void BuildHeap(int[] arr, int heapSize)
    {
        heapSize = arr.Length - 1;
        for (int i = arr.Length / 2; i >= 0; i--)
        {
            Heapify(arr, i, heapSize);
        }
    }

    static void Heapify(int[] arr, int i, int heapSize)
    {
        int largest;
        int left = Left(i);
        int right = Right(i);
        if (left <= heapSize && arr[left] > arr[i])
            largest = left;
        else 
            largest = i;
        if (right <= heapSize && arr[right] > arr[largest])
            largest = right;
        if (largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            Heapify(arr, largest, heapSize);
        }
    }

    static int Left(int i)
    {
        return 2 * i;
    }

    static int Right(int i)
    {
        return 2 * i + 1;
    }
}
