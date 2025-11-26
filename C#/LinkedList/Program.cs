using linkedlist.UIManager;
using LinkedList.FileIO;
using LinkedList.List;
namespace LinkedList.demo;


public class Program 
{
    public static void Main( String[] args )
    {
            FileIOManager fileMgr = new FileIOManager();

            LinkedListNode list = fileMgr.Deserialize("list.json");

            UIManager mgr = new UIManager();

            int choice;
            int data;
        
            do
            {
                mgr.showMenu();
                choice = mgr.getChoice();

                switch (choice)
                {

                    case 1:
                        {
                            Console.WriteLine("Enter the data  : ");
                            data =int.Parse(Console.ReadLine());
                            list.insert(data);
                        }
                        break;

                    case 2:
                        {
                        Console.WriteLine("Enter the data  : ");
                            data =  int.Parse(Console.ReadLine());
                        list.remove(data);
                        }
                        break;

                    case 3:
                        {
                        Console.WriteLine("Enter the data  : ");
                            data = int.Parse(Console.ReadLine());
                        bool status = list.search(data);
                        Console.WriteLine(status);
                        }
                        break;

                    case 4:
                        list.display();
                        break;

                    case 5:
                        fileMgr.Serialize(list, "list.json");
                        break;

                    default:
                    Console.WriteLine("You choose to exit");
                        break;
                }
            } while (choice != 6);

        }

    }
