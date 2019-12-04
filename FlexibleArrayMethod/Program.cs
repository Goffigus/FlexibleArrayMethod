using static System.Console;
public class FlexibleArrayMethod
{
    static void Main()
    {
        int[] arr1 = { 2, 5, 6, 4 };
        int[] arr2 = { 2, 5, 6, 4, 9};
        int[] arr3 = { 2, 5, 6, 4, 9, 20};

        DisplayAndSum(arr1);
        DisplayAndSum(arr2);
        DisplayAndSum(arr3);
    }
    public static void DisplayAndSum(int[] arr)
    {

        //Efficient way of coding
        /*
         *
        int sum = 0;
        for (int x = 0; x < arr.Length; ++x)
        {
            WriteLine(arr[x]);
            sum += arr[x];
        }
        WriteLine(sum);
        */

        //lazy way
        printArray(arr);
        int sum = SumOfArray(arr);
        WriteLine(sum);
    }
    private static void printArray(int[] someArray)
    {
        for (int x = 0; x < someArray.Length; ++x)
        {
            WriteLine(someArray[x]);
        }
    }

    private static int SumOfArray(int[] someArray)
    {
        int sum = 0;
        for (int i = 0; i < someArray.Length; ++i)
        {
            sum += someArray[i];
        }

        return sum;
    }
}