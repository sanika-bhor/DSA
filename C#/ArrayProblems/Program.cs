
using ArrayProblems;

int[] arr=[11,32,300,96,5,63,255,299,78,10];


Max_Min_Element maximum_Element =new Max_Min_Element(arr);
int maxElement=maximum_Element.FindMaxElement();
Console.WriteLine("Maximum Element: "+maxElement);

int minElement = maximum_Element.FindMinElement();
Console.WriteLine("Minimum Element: " + minElement);


Second_Largest_Element second_Largest_Element = new Second_Largest_Element(arr);
int secondLargeElement=second_Largest_Element.FindSecondLargestElement();
Console.WriteLine("second Largest Element: " + secondLargeElement);

Reverse_Array_InPlace reverse_Array_InPlace= new Reverse_Array_InPlace(arr);
reverse_Array_InPlace.DoReverseInPlace();
reverse_Array_InPlace.DisplayArray();

