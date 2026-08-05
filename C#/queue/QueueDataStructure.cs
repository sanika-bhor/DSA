namespace tflQueeue
{
    public class QueueDataStructure
    {
        public int[] Queue {get;set;}
        public int Front{get;set;}
        public int Rear{get;set;}

        public QueueDataStructure(int size)
        {
            Queue=new int[size];
            this.Front=-1;
            this.Rear=-1;
        }

        public void DisplayQueue()
        {
            if(Rear==-1 && Front==-1)
            {
               Console.WriteLine("Queuee is empty");
            }
            else
            {
                for (int i = Front; i <= Rear; i++)
                {
                    Console.WriteLine(Queue[i]);
                }
            }
        }


        public void OverFlow()
        {
            
        }

        public void EnQueue(int data)
        {
            if(Front==-1)
            {
                Front++;
                Rear++;
                Queue[Rear]=data;
            }
            else
            {
               
                if(Rear==9)
                {
                    Console.WriteLine("Queue is full");
                    // Rear=Queue.Length;
                }
                else
                {
                    Rear++;
                    Queue[Rear]=data;
                }
            }
        }


        public void DeQueue()
        {
            if(Rear==-1)
            {
                Console.WriteLine("Queue is empty");
            }
            else if(Rear==Front)
            {
                Rear=-1;
                Front=-1;
            }
            else
            {
                int oldData=Queue[Front];
                Front++;
                Console.WriteLine("you deleted:"+oldData);
            }
        }

    
    }
}