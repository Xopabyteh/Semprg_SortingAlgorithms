using System.Text;

namespace SortingAlgorithms;
class Utils {
    public static void PrintArray(int[] arr)
    {
        StringBuilder builder = new StringBuilder();
        foreach (int t in arr)
        {
            builder.Append(t.ToString().PadLeft(3));
        }

        Console.WriteLine(builder.ToString());
    }

    public static int[] RandomArray(int s)
    {
        Random rng = new Random();
        int[] arr = new int[s];
        for (int i = 0; i < s; i++)
        {
            arr[i] = rng.Next(10);
        }

        return arr;
    }
}