namespace ArrayProblems
{
    public class Second_Largest_Element
    {
        int[] arr;
        public Second_Largest_Element(int[] arr)
        {
            this.arr = arr;
        }

        public int FindSecondLargestElement()
        {
            int firstLargest = 0;
            int secondLargest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > firstLargest)
                {
                    secondLargest=firstLargest;
                    firstLargest = arr[i];
                }
                else if(arr[i]>secondLargest && arr[i]!=firstLargest)
                {
                   secondLargest=arr[i];
                }
            }
            return secondLargest;
        }
    }
}