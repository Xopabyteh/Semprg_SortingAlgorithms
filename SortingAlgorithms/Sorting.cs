namespace SortingAlgorithms;
public class Sorting
{
    //I Made this one first
    //Turns out to be the bouble sort
    public static int[] BoubleSort(int[] arr)
    {
        for (int j = 0; j < arr.Length - 1; j++) //So each time it goes one step times less
        {
            for (int i = 0; i < arr.Length - j - 1; i++)
            {
                int a = arr[i];
                int b = arr[i + 1];
                if (a > b)
                {
                    //Tuple swap
                    (arr[i], arr[i + 1]) = (b, a);
                }
            }
        }
        return arr;
    }

    //I've done this one myself by reading about how it works
    //Then i looked at the code they supplied and tweaked it
    public static int[] SelectionSort(int[] arr)
    {
        for (int o = 0; o < arr.Length - 1; o++)
        {
            int iLargest = o;
            for (int i = o + 1; i < arr.Length ; i++)
            {
                int current = arr[i];
                int largest = arr[iLargest];
                if (current > largest)
                {
                    iLargest = i;
                }
            }
            //Tuple swap
            (arr[o], arr[iLargest]) = (arr[iLargest], arr[o]);
        }

        return arr;
    }

    //Im not really sure whether i understand this one
    public static int[] InsertionSort(int[] arr)
    {
        List<int> list = new List<int>() {arr[0]};
        for (int i = 1; i < arr.Length; i++)
        {
            int current = arr[i];
            for (int j = 0; j < list.Count; j++)
            {
                if (current < list[j])
                {
                    list.Insert(j,current);
                    break;
                }
            }
        }

        return list.ToArray();
    }

    //Absolutely legendary
    public static int[] BozoSort(int[] arr)
    {
        Random rng = new Random();
        while (true)
        {
            bool sorted = true;
            //Sort check
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    sorted = false;
                    break;
                }
            }

            if (sorted)
            {
                return arr;
            }
            //Swap two elements
            int a = rng.Next(arr.Length);
            int b = rng.Next(arr.Length);
            (arr[a], arr[b]) = (arr[b], arr[a]);
            //Utils.PrintArray(arr);
        }
    }
}
