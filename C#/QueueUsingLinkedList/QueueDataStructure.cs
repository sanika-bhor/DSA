namespace tflQueeue
{
    public class QueueDataStructure
    {
        public Node Rear { get; set; } = null;
        public Node Front { get; set; } = null;
        // public int Front{get;set;}
        // public int Rear{get;set;}

        // public QueueDataStructure()
        // {
        //     Queue = new Node();
        //     // this.Front=window.Front;
        //     // this.Rear=window.Rear;
        // }

        public void DisplayQueue()
        {
            if (Rear == null && Front == null)
            {
                Console.WriteLine("Queuee is empty");
            }
            else
            {
                // for (Node node = Front; node !=Rear; node = node.Next)
                // {
                //     Console.WriteLine(" value:" + node.Data);
                // }

                Node node = Front;
                while (node != null)
                {
                    Console.WriteLine(" value:" + node.Data);
                    node = node.Next;
                }
            }
        }


        public void EnQueue(int data)
        {
            Node newNode = new Node(data);
            if (Front == null)
            {
                Front = newNode;
                Rear = newNode;
                Console.WriteLine("Data inserted: " + data);
            }
            else
            {

                Rear.Next = newNode;
                Rear = Rear.Next;
                Console.WriteLine("Data inserted: " + data);
            }
        }


        public void DeQueue()
        {
            if (Rear == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else if (Front == Rear)
            {
                Front = null;
                Rear=null;
                Console.WriteLine("Queue is empty");
            }
            else
            {
                int oldData = Front.Data;
                Front=Front.Next;
                Console.WriteLine("you deleted:" + oldData);
            }
        }


    }
}