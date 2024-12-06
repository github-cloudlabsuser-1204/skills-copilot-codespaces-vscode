using System;

class Program
{
    const int MAX = 100;

    static int Sum(int[] arr)
    {
        int result = 0;
        foreach (int num in arr)
        {
            result += num;
        }
        return result;
    }

    static int GetValidNumber(string prompt, int min, int max)
    {
        int number;
        do
        {
            Console.Write(prompt);
        } while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max);

        return number;
    }

    static int[] GetValidIntegers(int count)
    {
        int[] arr = new int[count];
        for (int i = 0; i < count; i++)
        {
            arr[i] = GetValidNumber($"Enter integer {i + 1}: ", int.MinValue, int.MaxValue);
        }
        return arr;
    }

    static void Main()
    {
        int n = GetValidNumber("Enter the number of elements (1-100): ", 1, MAX);
        int[] arr = GetValidIntegers(n);
        int total = Sum(arr);
        Console.WriteLine("Sum of the numbers: " + total);
    }
}