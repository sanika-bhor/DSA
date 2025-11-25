using LinkedList.List;
namespace LinkedList.demo;


public class Program 
{
    public static void Main( String[] args )
    {
        Console.WriteLine( "Hello World!" );
        LinkedListNode list =new LinkedListNode();

        list.insert(20);
        list.insert(30);
        list.insert(40);
        list.insert(50);
        list.display();

        list.remove(30);

        list.display();
    }
}
