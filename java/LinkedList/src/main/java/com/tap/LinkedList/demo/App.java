package com.tap.LinkedList.demo;


public class App 
{
    public static void main( String[] args )
    {
        System.out.println( "Hello World!" );
        LinkedList list=new LinkedList();

        list.insert(20);
        list.insert(30);
        list.insert(40);
        list.insert(50);
        list.display();

        list.remove(30);

        list.display();
    }
}
