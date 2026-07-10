namespace TFLCollection
{
    public class LinkedList
    {
      public Node head=null;
      public Node tail=null;

      public void InsertAtFirst(int data)
      {
        Node newNode=new Node(data);
            if(head==null)
            {
                head=newNode;
                tail = head;
            }
            else
            {
                head.Prev=newNode;
                newNode.Next=head;
                head=newNode;
            }
        }

        public void InsertAtLast(int data)
        {
            Node newNode=new Node(data);

            Node current=head;
            while(current.Next!=null)
            {
                current=current.Next;
            }

            current.Next=newNode;
            newNode.Prev=current;
            tail=newNode;
        }

        public void InsertAtMiddle(int data)
        {
            Node newNode = new Node(data);

            Node current = head;
            while (current.Next.data < data)
            {
                current = current.Next;
            }
            newNode.Next=current.Next;
            current.Next.Prev=newNode;
            newNode.Prev=current;
            current.Next = newNode;
        }

        public void UpdateAnyWhere(int oldData,int newData)
        {
        
            Node current = head;
            while (current!=null)
            {
                if(current.data==oldData)
                {
                    current.data=newData;
                    break;
                }
                current = current.Next;
            }
            
        }

        public void Delete(int data)
        {
            if (head.data == data)
            {
                if(head.Next==null)
                {
                    head= null;
                    tail=null;
                }
                else
                {
                    head=head.Next;
                }
            }
            else
            {
                Node current = head;
                while (current.Next.data != data)
                {
                    current = current.Next;
                }

                if (current.Next.Next == null)
                {
                    current.Next = null;
                    tail=current;
                }
                else
                {
                    current.Next = current.Next.Next;
                    current.Next.Prev = current;
                }
            }

        }


        public void DisplayFromHead()
        {
            Node current = head;
            Console.WriteLine("\n\n\nNext Element: ");
            Console.Write("null--->");
            while (current != null)
            {
                Console.Write(current.data+"--->");
                current = current.Next;
            }
            Console.Write("null\n");
           
        }

        public void DisplayFromTail()
        {
            Console.WriteLine("Prev Element");
            Console.Write("null");
            Node current = tail;
            while (current != null)
            {
                Console.Write("<---" + current.data);
                current = current.Prev;
            }
            Console.Write("<---null");
        }
    }
}