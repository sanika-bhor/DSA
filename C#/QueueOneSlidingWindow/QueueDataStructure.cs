namespace tflQueeue
{
    public class QueueDataStructure
    {
        // public Window[] window;
        // public int NoOfWindows{get;set;}
        public int[] Queue {get;set;}
        // public int Front{get;set;}
        // public int Rear{get;set;}

        public QueueDataStructure(int size)
        {
            // this.window = window;
            Queue=new int[size];
            // this.Front=window.Front;
            // this.Rear=window.Rear;
        }

        public void DisplayQueue(Window window)
        {
            if(window.Rear == window.StartIndex - 1 && window.Front == window.StartIndex - 1)
            {
               Console.WriteLine("Queuee is empty");
            }
            else
            {
                for (int i = window.Front; i <= window.Rear; i++)
                {
                    Console.WriteLine("index "+i+" value:"+Queue[i]);
                }
            }
        }


        public void EnQueue(Window window,int data)
        {
            if(window.Front == window.StartIndex - 1)
            {
                window.Front++;
                window.Rear++;
                Queue[window.Rear] =data;
            }
            else
            {
                if(window.Rear == window.EndIndex )
                {
                    Console.WriteLine("Queue is full");
                    // Rear=Queue.Length;
                }
                else
                {
                    window.Rear++;
                    Queue[window.Rear] =data;
                }
            }
        }


        public void DeQueue(Window window)
        {
            if(window.Rear == window.StartIndex-1)
            {
                Console.WriteLine("Queue is empty");
            }
            else if(window.Rear == window.Front)
            {
                window.Rear = window.StartIndex-1;
                window.Front = window.StartIndex - 1;
            }
            else
            {
                int oldData=Queue[window.Front];
                window.Front++;
                Console.WriteLine("you deleted:"+oldData);
            }
        }

    
    }
}