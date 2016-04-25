static void BubbleSort(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = 0; j < mas.Length - i - 1; j++)
        {
            if (mas[j] < mas[j + 1])
            {
                int temp = mas[j];
                mas[j] = mas[j + 1];
                mas[j + 1] = temp;
                }
            }
        }
    }
}
