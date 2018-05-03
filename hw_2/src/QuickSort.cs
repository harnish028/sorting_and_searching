public static class QS
{
    public static void QuickSort(int[] arr, int left, int right)
    {
        if(left < right)
        {
            int q = Partition(arr, left, right);
            QuickSort(arr, left, q - 1);
            QuickSort(arr, q + 1, right);
        }
    }

    static int Partition(int[] arr, int left, int right)
    {
        int temp;
        int x = arr[right];
        int i = left - 1;
        for (int j = left; j <= right - 1; j++)
        {
            if (arr[j] <= x)
            {
                i++;
                temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }
        temp = mas[right];
        mas[right] = mas[i + 1];
        mas[i + 1] = temp;
           
        return i + 1;
    }
}
