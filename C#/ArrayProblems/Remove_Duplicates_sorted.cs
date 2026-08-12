namespace ArrayProblems
{
    public class Remove_Duplicates_sorted
    {
        int[] arr;
        int len;

        public Remove_Duplicates_sorted(int[] arr)
        {
            this.arr = arr;
            len = arr.Length;
        }

        public int RemoveDuplicates()
        {
            int uniqueCount=len;
           

            for (int i = 0; i <len-1; i++)
            {
                if(arr[i]==arr[i+1])
                {
                   len--;
                    uniqueCount--;
                    for (int j = i + 1; j<len; j++)
                    {
                        arr[j] = arr[j + 1];

                    }
                    i--;
                }
               

            }
            return uniqueCount;
        }

        public void DisplayArray()
        {
            Console.Write("after duplicate remove Array: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(arr[i] + "  ");
            }
        }
    }
}