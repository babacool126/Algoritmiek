using System;
class Program {
    static void QuickSort (int[] arr, int low, int high) {
        if (low < high) {

        int pivotIndex = Partition(arr, low, high);
        QuickSort(arr, low, pivotIndex -1);
        QuickSort(arr, pivotIndex + 1, high);
        }
    }

    static int Partition  (int[] arr, int low, int high) {
       int pivot = arr[high];
       int i = low - 1;
       for (int j = low; j < high; j++) {
            if (arr[j] <= pivot) {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
       }

       (arr[i+1], arr[high]) = (arr[high], arr[i+1]);
       return i + 1;
    }
    static void Main() {
        int[] numbers = {8,3,5,1,7};
        QuickSort(numbers, 0, numbers.Length -1);
        Console.WriteLine(String.Join(",", numbers));
    }
}