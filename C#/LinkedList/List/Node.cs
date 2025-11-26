namespace LinkedList.node
{
    [Serializable]
    public class Node
    {
        public int data{get;set;}
        public Node next{get; set;}

        public Node()
        {
            this.data = 10;
            this.next = null;
        }

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
