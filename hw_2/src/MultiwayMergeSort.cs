public static class MultiwayMergeS
{
    public static void MultiwayMergeSort(int[] arr, int left, int right, int parts)
    {
        if(left < right)
        {
            int lenght = (right - left) / parts + 1;
            Merge(arr, left, right, lenght, parts);
        }
    }

    public static void Merge(int[] arr, int left, int right, int lenght, int parts)
    {
        int[][] array = new int[parts][];

        for (int i = 0; i < parts; i++)
        {
            array[i] = new int[lenght + 1];
        }

        for(int i = 0;  i < parts; i++)
        {
            for(int j = 0; j < lenght; j++)
            {
                array[i][j] = arr[left + lenght * i + j];
            }
            array[i][lenght + 1] = int.MaxValue;
        }

        int[] indexes = new int[parts];
        int min = 0;

        for(int i = left; i < right; i++)
        {
            for(int j = 0; j < parts; j++)
            {
                if(array[j][indexes[j]] < array[min][indexes[min]])
                {
                    min = j;
                }
                arr[i] = array[min][indexes[min]];
                indexes[min]++;
            }
        }
    }
}
