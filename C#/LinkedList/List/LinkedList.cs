using System.Text.Json.Serialization;
using LinkedList.node;

namespace LinkedList.List
{

    [Serializable]
    public class LinkedListNode
    {
       public Node head{get;set;}

        public LinkedListNode()
        {
            this.head = null;
        }

        public void insert(int item)
        {
            Node newNode = new Node(item);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;

                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
            }
        }


        public int remove(int data)
        {
            Node prev = null;
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return -1;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.next != null)
                {
                    prev = currentNode;
                    currentNode = currentNode.next;
                    if (currentNode.data == data)
                    {
                        int value = currentNode.data;
                        prev.next = currentNode.next;
                        currentNode = null;
                        return value;
                    }
                }
            }
            return -1;

        }

        public void display()
        {

            Node currentNode = head;

            if (currentNode == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.data + "--->");
                    currentNode = currentNode.next;
                }
            }
            Console.WriteLine("null");
        }

        public bool search(int data)
        {
            Node currentNode = head;
            bool status = false;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
                if (currentNode.data == data)
                {
                    currentNode = null;
                    status = true;
                }
            }
            return status;

        }
    }
}
