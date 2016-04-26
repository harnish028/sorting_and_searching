public static class QS
{
    public static void QuickSort(int[] mas, int left, int right)
    {
        if(left < right)
        {
            int q = Partition(mas, left, right);
            QuickSort(mas, left, q - 1);
            QuickSort(mas, q + 1, right);
        }
    }

    static int Partition(int[] mas, int left, int right)
    {
        int temp;
        int x = mas[right];
        int i = left - 1;
        for (int j = left; j <= right - 1; j++)
        {
            if (mas[j] <= x)
            {
                i++;
                temp = mas[j];
                mas[j] = mas[i];
                mas[i] = temp;
            }
        }
        temp = mas[right];
        mas[right] = mas[i + 1];
        mas[i + 1] = temp;
           
        return i + 1;
    }
}
