static void InsertionSort(int[] mas)
{
    for (int i = 1; i < mas.Length; i++)
    {
        int j = i - 1;
        while ((j >= 0) && (mas[j] > mas[j + 1]))
        {
            int swap = mas[j];
            mas[j] = mas[j + 1];
            mas[j + 1] = swap;
            j--;
        }
    }
}
