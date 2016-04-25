static void SelectionSort(int[] mas)
{
  for (int i = 0; i < (mas.Length - 1); i++)
  {
    int min = i;
    for (int j = i + 1; j < mas.Length; j++)
    {
      if (mas[j] < mas[min])
      {
        min = j;
      }
    }
    int temp = mas[i];
    mas[i] = mas[min];
    mas[min] = temp;
  }
}
