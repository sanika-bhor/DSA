namespace linkedlist.UIManager;

public class UIManager
{

    public void showMenu()
    {
        Console.WriteLine("1 Insert the data");
        Console.WriteLine("2 Remove an element");
        Console.WriteLine("3 Search an Element");
        Console.WriteLine("4 Display the data");
        Console.WriteLine("5 Save the data");
        Console.WriteLine("6 Exit");
        Console.WriteLine("***********************************");
    }

    public int getChoice()
    {
        int choice;
        Console.WriteLine("Enter your choice : ");
        choice = int.Parse(Console.ReadLine());
        return choice;
    }

}