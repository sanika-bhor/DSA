package com.tap.stack.demo;

public class Shelf {
    public int top;
    public Book[] book=new Book[5];
    public final int SIZE = 5;

    public Shelf()
    {
        this.top=-1;
    }

    public void push(Book newBook)
    {
        if(this.top> SIZE)
        {
            System.out.println("stack is full");
        }
        else
        {
            this.top++;
            book[top]=newBook;
        }
    }

    public Book pop()
    {
        Book theBook;
        if(this.top == -1)
        {
            System.out.println("stack is empty");
            return null;
        }
        else
        {
             theBook=book[top];
            this.top--;
        }
        return theBook;
    }

    public void display()
    {
        for(int i=top; i > -1;i-- )
        {
            System.out.println("\nid: "+book[i].id+"\nTitle: "+book[i].title+"\nAuthor: "+book[i].author);
        }
    }
}
