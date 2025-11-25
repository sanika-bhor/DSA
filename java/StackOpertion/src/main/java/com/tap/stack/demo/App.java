package com.tap.stack.demo;

import java.util.Scanner;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        int choice;
        FileIoManager mgr=new FileIoManager();

        Scanner sc=new Scanner(System.in);
        Shelf motivationalBook = mgr.readFromFile();

        System.out.println("----Menu------");
        System.out.println("1. Add new Book");
        System.out.println("2. remove top book");
        System.out.println("3. display all books");
        System.out.println("4. save to file");
        System.out.println("5.exit");
        

        do
        {
            System.out.println("\nEnter your choice:");
            choice = sc.nextInt();

            switch (choice) {
                case 1:
                {
                    System.out.println("Enter book id: ");
                    int id=sc.nextInt();
                    sc.nextLine();

                    System.out.println("enter book title");
                    String title=sc.nextLine();

                    System.out.println("enter book author");
                    String author=sc.nextLine();

                    Book newBook = new Book(id,title,author);
                    motivationalBook.push(newBook);
                    System.out.println("Book put on the shelf you can check");
                    break;
                }
                case 2:
                    Book newBook=motivationalBook.pop();
                    System.out.println("Book take from the shelf: "+newBook.title);
                    break;
            
                case 3:
                     motivationalBook.display();
                     break;
                
                 case 4:
                     mgr.saveToFile(motivationalBook);

                default:
                    break;
            }
            
        }while(choice!=5);
    }
}
