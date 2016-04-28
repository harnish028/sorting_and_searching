public static class Merger
{
    public static void MergeSort(int[] arr, int left, int right)
    {
        if(left < right)
        {
            int middle = (left + right) / 2;
            MergeSort(arr, left, middle);
            MergeSort(arr, middle + 1, right);
            Merge(arr, left, middle, right);
        }
    }

    static void Merge(int[] arr, int left, int middle, int right)
    {
        int[] buf = new int[right - left + 1];
        int leftArr = left;
        int rightArr = middle + 1;
        int i = 0;
        int k = 0; 

        while (leftArr <= middle && rightArr <= right)
        {
            if (arr[leftArr] < arr[rightArr])
            {
                buf[i++] = arr[leftArr++];
            }
            else
            {
                    buf[i++] = arr[rightArr++];
            }
        }
            
        if(leftArr > middle)
        {
            for(k = rightArr; k <= right; k++)
            {
                buf[i++] = arr[k];
            }
        }
        else
        {
            for(k = leftArr; k <= middle; k++)
            {
                buf[i++] = arr[k];
            }
        }

        for(k = 0; k < right - left + 1; k++)
        {
            arr[k + left] = buf[k];
        }
    }
} 
