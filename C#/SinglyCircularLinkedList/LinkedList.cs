namespace TFLCollections
{
    public class LinkedList
    {
        Node head = null;
        // Node tail=null;

        public void AddNodeEnd(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                head.next = head;
            }
            else
            {
                Node current = head;
                while (current.next != head)
                {
                    current = current.next;
                }
                current.next = newNode;
                newNode.next = head;
            }

        }

        public void AddNodeFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                head.next = head;
            }
            else
            {

                Node current = head;
                while (current.next != head)
                {
                    current = current.next;
                }
                // tail.next=head;

                newNode.next = head;
                current.next = newNode;
                head = newNode;
            }

        }

       public void AddNodeAnyWhere(int data)
        {
            Node newNode = new Node(data);

            Node current=head;
            while(current.next != head && current.next.data<data)
            {
                current=current.next;
            }
            newNode.next=current.next;
            current.next=newNode;
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Circular Linked List is empty.");
                return;
            }
            Node current = head;
            Console.WriteLine("Circular Linked List");
            while (current.next != head)
            {
                Console.Write(current.data + "-->");
                current = current.next;
            }
            Console.Write(current.data + "-->");
        }

    }

}