namespace Complexity_exercises_and_running_time;

public class EffectiveComplicationsExercises
{
    // O(n) n * 8
    public static int Ex1CalculateOddSum(int[] arr)
    {
        int sumOddNumber = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
                sumOddNumber += arr[i];
        }
        return sumOddNumber;
    }

    // O(n)
    public static int[] Ex2FindMaximumTwo(int[] arr)
    {
        int max1 = arr[0];
        int max2 = arr[1];
        int sumMax = arr[0] + arr[1];
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] + arr[i + 1] > sumMax)
            {
                max1 = arr[i];
                max2 = arr[i + 1];
                sumMax = arr[i] + arr[i + 1];
            }
        }
        return new int[] { max1, max2 };
    }

    // O(n)
    public static bool Ex3ContainsNumber(int[] array, int number)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
                return true;
        }
        return false;
    }

    // O(n)
    public static int[] Ex4SumOfAllTriplets(int[] array)
    {
        int num1 = array[0];
        int num2 = array[1];
        int num3 = array[2];
        int sumNum = num1 + num2 + num3;
        for (int i = 2; i < array.Length - 2; i++)
        {
            if (array[i] + array[i + 1] + array[i + 2] > sumNum)
            {
                num1 = array[i];
                num2 = array[i + 1];
                num3 = array[i + 2];
                sumNum = num1 + num2 + num3;
            }
        }
        return new int[] { num1, num2, num3 };
    }

    // O(n)
    public static int[] Ex5FindLastClosePairWithProduct(int[] array, int product)
    {
        int num1 = int.MinValue;
        int num2 = int.MinValue;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] * array[i + 1] == product)
            {
                num1 = array[i];
                num2 = array[i + 1];
            }
        }
        return new int[] { num1, num2 };
    }

    // O(n)
    public static int[] Ex5FindLastNotClosePairWithProduct(int[] array, int product)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            if (array[i] * array[i - 1] == product)
            {
                return new int[] { array[i], array[i - 1] };
            }
        }
        return new int[] { 0, 0 };
    }

    // O(n)
    public static int Ex6CountEvenNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                count++;
        }
        return count;
    }

    //
    public static int[] Ex7MergeSortedArraysUnique(int[] array1, int[] array2)
    {
        int[] newArray = new int[array1.Length + array2.Length];
        int i = 0;
        int j = 0;
        int k = 0;
        while (i < array1.Length && j < array2.Length)
        {
            if (array1[i] < array2[j])
            {
                if (k == 0 || newArray[k - 1] != array1[i])
                {
                    newArray[k++] = array1[i];
                }
                i++;
            }
            else
            {
                if (k == 0 || newArray[k - 1] != array2[j])
                {
                    newArray[k++] = array2[j];
                }
                j++;
            }
        }
        while (i < array1.Length)
            if (newArray[k] != array1[i])
                newArray[k++] = array1[i++];
        while (j < array2.Length)
            if (newArray[k] != array2[j])
                newArray[k++] = array2[j++];
        if (k < newArray.Length)
        {
            int[] tmp = new int[k];
            for (int l = 0; l < k; l++)
            {
                tmp[l] = newArray[l];
            }
            newArray = tmp;
        }

        return newArray;
    }
}
