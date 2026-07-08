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

   
      public void Update(int oldData,int newData)
        {
            Node current = head;
            while (current.next != head)
            {
                if(current.data==oldData)
                {
                    current.data = newData;
                }
                current = current.next;
            }
        }

        public void Delete(int data)
        {
            if(head.data==data)
            {
                if(head.next==head)
                {
                    head=null;
                }
                else
                {
                 
                    Node current = head;
                    while (current.next != head)
                    {
                        current = current.next;
                    }
                    head = head.next;
                    current.next=head;
                }

            }
           
            else
            {
                // 5 10 12 13 15 16
                Node current = head;
                while (current.next != head)
                {
                    if (current.next.data == data)
                    {
                        if(current.next.next==head)
                        {
                            current.next=head;
                        }
                        else
                        {
                            current.next=current.next.next;
                        }
                    }
                    current = current.next;
                }
            }
        }
    }

}