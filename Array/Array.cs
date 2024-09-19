using System;
using System.Collections.Generic;
using System.Linq;

namespace Array;

public class Array
{
    // תרגיל 1
    //O(n)
    public static int CalculateOddSum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            if (num % 2 != 0)
            {
                sum += num;
            }
        }
        return sum;
    }

    // תרגיל 2
    //O(n)
    public static int FindMaximumTwo(int[] array)
    {
        if (array.Length < 2) return int.MinValue;
        int maxSum = array[0] + array[1];
        for (int i = 1; i < array.Length - 1; i++)
        {
            int currentSum = array[i] + array[i + 1];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        return maxSum;
    }

    // תרגיל 3
    //O(n)
    public static bool ContainsNumber(int[] array, int number)
    {
        foreach (int num in array)
        {
            if (num == number)
            {
                return true;
            }
        }
        return false;
    }

    // תרגיל 4
    //O(n)
    public static int SumOfTopThreeNumbers(int[] array)
    {
        if (array.Length < 3) return 0;


        int max1 = int.MinValue, max2 = int.MinValue, max3 = int.MinValue;

        foreach (int num in array)
        {
            if (num > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = num;
            }
            else if (num > max2)
            {
                max3 = max2;
                max2 = num;
            }
            else if (num > max3)
            {
                max3 = num;
            }
        }
        return max1 + max2 + max3;
    }


    // תרגיל 5
    //O(n)
    public static (int, int)? FindLastPairWithProduct(int[] array, int product)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            if (array[i] * array[i - 1] == product)
            {
                return (array[i - 1], array[i]);
            }
        }
        return null;
    }

    // תרגיל 6
    //O(n)
    public static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    // תרגיל 7
    //O(n + m)
    public static int[] MergeSortedArraysUnique(int[] array1, int[] array2)
    {
        List<int> result = new List<int>();
        int i = 0, j = 0;
        int? lastAdded = null;

        while (i < array1.Length && j < array2.Length)
        {
            if (array1[i] < array2[j])
            {
                if (lastAdded != array1[i])
                {
                    result.Add(array1[i]);
                    lastAdded = array1[i];
                }
                i++;
            }
            else if (array1[i] > array2[j])
            {
                if (lastAdded != array2[j])
                {
                    result.Add(array2[j]);
                    lastAdded = array2[j];
                }
                j++;
            }
            else
            {
                if (lastAdded != array1[i])
                {
                    result.Add(array1[i]);
                    lastAdded = array1[i];
                }
                i++;
                j++;
            }
        }
        while (i < array1.Length)
        {
            if (lastAdded != array1[i])
            {
                result.Add(array1[i]);
                lastAdded = array1[i];
            }
            i++;
        }
        while (j < array2.Length)
        {
            if (lastAdded != array2[j])
            {
                result.Add(array2[j]);
                lastAdded = array2[j];
            }
            j++;
        }
        return result.ToArray();
    }


    // תרגיל 8
    //O(n^2)
    public static void FindPairsWithSum(int[] array, int sum)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == sum)
                {
                    Console.WriteLine($"Pair: {array[i]}, {array[j]}");
                }
            }
        }
    }

    // תרגיל 9
    ////O(n)
    public static Dictionary<int, int> CountFrequency(int[] array)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int num in array)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }
        return frequency;
    }

    // תרגיל 10
    //O(n)
    public static int FindMaxSubarraySum(int[] array)
    {
        int maxSoFar = array[0], maxEndingHere = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (maxEndingHere + array[i] > array[i])
            {
                maxEndingHere = maxEndingHere + array[i];
            }
            else
            {
                maxEndingHere = array[i];
            }

            if (maxEndingHere > maxSoFar)
            {
                maxSoFar = maxEndingHere;
            }
        }
        return maxSoFar;
    }


    // תרגיל 11
    //O(n)
    public static int FindFirstRepeating(int[] array)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in array)
        {
            if (seen.Contains(num))
            {
                return num;
            }
            seen.Add(num);
        }
        return -1;
    }

    // תרגיל 12
    //O(n)
    public static int FindMissingNumber(int[] array, int n)
    {
        int expectedSum = (n * (n + 1)) / 2;
        int actualSum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            actualSum += array[i];
        }
        return expectedSum - actualSum;
    }

    // תרגיל 13
    //O(n)
    public static int FindMissingNumberUnsorted(int[] array, int n)
    {
        int expectedSum = (n * (n + 1)) / 2;
        int actualSum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            actualSum += array[i];
        }
        return expectedSum - actualSum;
    }
    public void nothing(int n) { }
}
