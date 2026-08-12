namespace ArrayProblems
{
    public class CheckArraySorted
    {
        int[] arr; 
        public CheckArraySorted(int[] arr)
        {
            this.arr = arr;
        }

        public bool IsSorted()
        {
            bool status=true;
            for (int i = 0;i<arr.Length-1;i++)
            {
                if (arr[i]>arr[i+1])
                {
                    status=false;
                }
            }
            return status;
        }
    }
}