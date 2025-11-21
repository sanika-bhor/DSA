package com.tap.LinkedList.demo;

public class LinkedList {
    Node head;

    public LinkedList() {
        this.head = null;
    }

    public void insert(int item) {
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
        Node prev=null;
        if (head == null) {
            System.out.println("List is empty");
            return -1;
        }
        else
        {
            Node currentNode = head;
            while (currentNode.next!=null) {
                prev=currentNode;
                currentNode = currentNode.next;
                if(currentNode.data==data)
                {
                    int value=currentNode.data;
                    prev.next=currentNode.next;
                    currentNode=null;
                    return value;
                }
            }
        }
        return -1;
    
    }

    public void display() {

        Node currentNode = head;

        if (currentNode == null) {
            System.out.println("List is empty");
        } else {
            while (currentNode != null) {
                System.out.print(currentNode.data + "--->");
                currentNode = currentNode.next;
            }
        }
        System.out.println("null");
    }

}
