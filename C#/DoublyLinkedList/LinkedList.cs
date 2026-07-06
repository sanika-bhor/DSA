namespace TFLCollection
{
    public class LinkedList
    {
      public Node head=null;

      public void InsertAtFirst(int data)
      {
        Node newNode=new Node(data);
            if(head==null)
            {
                head=newNode;
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
                }
                else
                {
                    current.Next = current.Next.Next;
                    current.Next.Prev = current;
                }
            }

        }


        public void Display()
        {
            Node last=null;;
            Node current = head;
            Console.WriteLine("\n\n\nNext Element: ");
            Console.Write("null--->");
            while (current != null)
            {
                Console.Write(current.data+"--->");
                last=current;
                current = current.Next;
            }
            Console.Write("null\n");
            Console.WriteLine("Prev Element");
            Console.Write("null");
            current=last;
            while (current != null)
            {
                Console.Write("<---"+ current.data);
                current = current.Prev;
            }
            Console.Write("<---null");
        }
    }
}