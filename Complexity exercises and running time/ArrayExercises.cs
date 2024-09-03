namespace data_structures;

public class ArrayExercises
{
    public static int[] Ex0CopyArray(int[] array)
    {
        int[] copy = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            copy[i] = array[i];
        }
        return copy;
    }

    public static int[] Ex1ReverseArray(int[] array)
    {
        int[] reversed = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reversed[i] = array[array.Length - 1 - i];
        }
        return reversed;
    }

    public static int Ex2Sum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    public static int Ex3Min(int[] arr)
    {
        int min = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }

    public static int[] Ex4MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int[] merge = new int[arr1.Length + arr2.Length];
        int indexMerge = 0;
        int indexArr1 = 0;
        int indexArr2 = 0;
        while (indexArr1 < arr1.Length && indexArr2 < arr2.Length)
        {
            if (arr1[indexArr1] < arr2[indexArr2])
            {
                merge[indexMerge] = arr1[indexArr1];
                indexArr1++;
                indexMerge++;
            }
            else
            {
                {
                    merge[indexMerge] = arr2[indexArr2];
                    indexArr2++;
                    indexMerge++;
                }
            }
        }
        if (indexArr1 + 1 < arr1.Length)
        {
            return Merge(indexMerge, merge, indexArr1, arr1);
        }
        else
        {
            return Merge(indexMerge, merge, indexArr2, arr2);
        }
    }

    public static int[] Merge(int indexMerge, int[] arrMarge, int indexArr, int[] arr)
    {
        for (int i = indexArr; i < arr.Length; ++i)
        {
            arrMarge[indexMerge] = arr[i];
        }
        return arrMarge;
    }

    public static int[] Ex5CountIncidence(int[] arr)
    {
        int[] incidence = new int[arr.Length];
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == i)
                {
                    count++;
                }
            }
            incidence[i] = count;
            count = 0;
        }

        return incidence;
    }

    public static int Ex6Average(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / arr.Length;
    }

    //public static int[] Ex7ArrayZigzag(int[] arr)
    //{
    //    for (int i = 1; i < arr.Length; i++)
    //    {
    //        if (arr[i - 1] < arr[i] && i % 2 == 1 || arr[i - 1] > arr[i] && i % 2 == 0)
    //        {
    //            int temp = arr[i - 1];
    //            arr[i - 1] = arr[i];
    //            arr[i] = temp;
    //        }
    //    }

    //    return arr;
    //}

    //public static int[] Ex8RecurringNumbers(int[] arr)
    //{
    //    int[] recurring = new int[0];


    //    return recurring;
    //}

    //public static int[] AddArray(int[] arr, int value)
    //{
    //    int[] arr2 = new int[arr.Length + 1];
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        arr2[i] = arr[i];
    //    }
    //    arr2[arr.Length] = value;
    //    return arr2;
    //}
}
