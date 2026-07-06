namespace TFLCollection
{
    public class Node
    {
        public int data;
        public Node Prev;
        public Node Next;
        public Node(int data)
        {
            this.data = data;
            this.Prev = null;
            this.Next = null;
        }
    }
}