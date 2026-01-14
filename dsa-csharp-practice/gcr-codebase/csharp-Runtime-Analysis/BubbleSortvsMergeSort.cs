static void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}
static void MergeSort(int[] arr)
{
    if (arr.Length <= 1) return;

    int mid = arr.Length / 2;
    int[] left = new int[mid];
    int[] right = new int[arr.Length - mid];

    Array.Copy(arr, 0, left, 0, mid);
    Array.Copy(arr, mid, right, 0, arr.Length - mid);

    MergeSort(left);
    MergeSort(right);
    Merge(arr, left, right);
}

static void Merge(int[] arr, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;

    while (i < left.Length && j < right.Length)
        arr[k++] = left[i] < right[j] ? left[i++] : right[j++];

    while (i < left.Length) arr[k++] = left[i++];
    while (j < right.Length) arr[k++] = right[j++];
}
