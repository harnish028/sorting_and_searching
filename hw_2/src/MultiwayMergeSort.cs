public static class MultiwayMergeS
{
    public static void MultiwayMergeSort(int[] arr, int left, int right, int parts)
    {
        if(left < right)
        {
            int lenght = (right - left) / parts + 1;
            parts = (right - left + 1) / length + 1;
            int lenghtOfLastArr = right - (left + (parts - 1) * lenght) + 1;
            
            for (int i = 0; i < parts - 1; i++)
                MultiwayMergeSort(arr,  left + lenght * i, left + lenght * (i + 1) - 1, parts);
            MultiwayMergeSort(arr, left + lenght * (parts - 1), left, parts);
            Merge(arr, left, right, lenght, lenghtOfLastArr, parts);
        }
    }

    public static void Merge(int[] arr, int left, int right, int lenght, lenghtOfLastArr, int parts)
    {
        int[][] tempArray = new int[parts][];

        for (int i = 0; i < parts - 1; i++)
        {
            tempArray[i] = new int[lenght + 1];
        }
        tempArray[parts - 1] = new int[lenghtOfLastArr + 1];

        for (int i = 0; i < parts - 1; i++)
        {
            for (int j = 0; j < lenght; j++)
            {
                tempArray[i][j] = arr[left + lenght * i + j];
            }
            tempArray[i][lenght] = int.MaxValue;
        }

        for (int i = 0; i < lenghtOfLastArr; i++)
        {
            tempArray[parts - 1][i] = arr[left + ((parts - 1) * lenght) + 1];
        }
        tempArray[parts - 1][lenghtOfLastArr] = int.MaxValue;

        int[] indexes = new int[parts];
        int min = 0;

        for (int i = left; i <= right; i++)
        {
            for (int j = 0; j < parts; j++)
            {
                if (tempArray[j][indexes[j]] < tempArray[min][indexes[min]])
                {
                    min = j;
                }
            }
        arr[i] = tempArray[min][indexes[min]];
        indexes[min]++;    
        }
    }
}
