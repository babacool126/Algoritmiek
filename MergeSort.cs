int[] numbers = { 8, 3, 5, 1, 9, 2, 7 };

int[] MergeSort(int[] arr)
{
    if (arr.Length <= 1)
        return arr;

    int mid = arr.Length / 2;

    int[] left = MergeSort(arr[..mid]);
    int[] right = MergeSort(arr[mid..]);

    return Merge(left, right);
}

int[] Merge(int[] left, int[] right)
{
    List<int> result = new();
    int i = 0, j = 0;

    while (i < left.Length && j < right.Length)
    {
        if (left[i] <= right[j])
            result.Add(left[i++]);
        else
            result.Add(right[j++]);
    }

    result.AddRange(left[i..]);
    result.AddRange(right[j..]);

    return result.ToArray();
}

Console.WriteLine(string.Join(", ", MergeSort(numbers)));
