namespace ArrayProblems
{
    public class Reverse_Array_InPlace
    {
        int[] arr;
        public Reverse_Array_InPlace(int[] arr)
        {
            this.arr = arr;
        }

        public void DoReverseInPlace()
        {
            int left=0;
            int right=arr.Length-1;
            while(left<right)
            {
                int temp=arr[left];
                arr[left]=arr[right];
                arr[right]=temp;
                left++;
                right--;
            }
        }

        public void DisplayArray()
        {
            Console.Write("Reverse Array: ");
            for (int i = 0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+"  ");
            }
        }
    }
}