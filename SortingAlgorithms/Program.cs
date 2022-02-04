using SortingAlgorithms;


//I Really enjoyed coding this
const int length = 6;

Utils.PrintArray(Sorting.BoubleSort(Utils.RandomArray(length)));

Console.WriteLine();

Utils.PrintArray(Sorting.InsertionSort(Utils.RandomArray(length)));

Console.WriteLine();

Utils.PrintArray(Sorting.SelectionSort(Utils.RandomArray(length)));

Console.WriteLine();

//Utils.PrintArray(Sorting.BozoSort(Utils.RandomArray(length))));

/*
 *Stable x Unstable sorting 1)
 *  Stable sorting preserves the order of the elements
 *  ex. When we have two balls with number 3 { 1 , 3_a , 2 , 4 , 5 , 3_b}
 *  A stable sort will keep the order -> {1 , 2 , 3_a , 3_b , 4... }
 *  Unstable might change it -> {1 , 2 , 3_b , 3_a ...}
 *Natural sorting 2)
 *  A Sorting that is more "human friendly"
 *  Sorting not by individual characters but by strings of characters
 *  {a11, a2} ->
 *  Normally sorted: {a11, a2}
 *  Naturally sorted: {a2, a11} bcz: 2 is considered less than 11
 *How do mentioned sorting algorithms work 3)
 *  Sorting.cs-->>
*/
