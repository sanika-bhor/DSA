using System.Runtime.CompilerServices;

namespace ArrayProblems
{
    public class Max_Min_Element
    {
        int[] arr;

        public Max_Min_Element(int[] arr)
        {
            this.arr = arr;
        }

        public int FindMaxElement()
        {
            int max=0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>max)
                {
                    max=arr[i];
                }
            }
            return max;
        }

        public int FindMinElement()
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}