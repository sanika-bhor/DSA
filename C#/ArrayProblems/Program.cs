
using ArrayProblems;

int[] arr=[10,11,12,13,14,14,16,17,18,18];
// int[] arr=[11,32,300,96,5,63,255,299,78,10];


Max_Min_Element maximum_Element =new Max_Min_Element(arr);
int maxElement=maximum_Element.FindMaxElement();
Console.WriteLine("Maximum Element: "+maxElement);

int minElement = maximum_Element.FindMinElement();
Console.WriteLine("Minimum Element: " + minElement);


Second_Largest_Element second_Largest_Element = new Second_Largest_Element(arr);
int secondLargeElement=second_Largest_Element.FindSecondLargestElement();
Console.WriteLine("second Largest Element: " + secondLargeElement);

// Reverse_Array_InPlace reverse_Array_InPlace= new Reverse_Array_InPlace(arr);
// reverse_Array_InPlace.DoReverseInPlace();
// reverse_Array_InPlace.DisplayArray();


CheckArraySorted checkArraySorted=new CheckArraySorted(arr);
bool isSortedStatus= checkArraySorted.IsSorted();
Console.WriteLine("\nIs Array sorted: " + isSortedStatus);

Remove_Duplicates_sorted remove_Duplicates_Sorted=new Remove_Duplicates_sorted(arr);
int count=remove_Duplicates_Sorted.RemoveDuplicates();
Console.WriteLine("\nunique in array: " + count);
remove_Duplicates_Sorted.DisplayArray();
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + "  ");
// }