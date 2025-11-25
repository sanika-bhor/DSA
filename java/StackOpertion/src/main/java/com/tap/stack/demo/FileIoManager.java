package com.tap.stack.demo;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class FileIoManager {
    
    public void saveToFile(Shelf motivationalShelf)
    {
        try{
        FileOutputStream fout=new FileOutputStream("books.txt");
        ObjectOutputStream ostream=new ObjectOutputStream(fout);
        // for(int i=0;i<motivationalShelf.top;i++)
        // {
            ostream.writeObject(motivationalShelf);
            ostream.close();
            fout.close();
            System.out.println("data save to file");
        // }
        }catch(Exception e)
        {
            System.out.println(e);
        }

    }


    public Shelf readFromFile() {
        Shelf motivationalShelf=new Shelf();
        try {
            FileInputStream fout = new FileInputStream("books.txt");
            ObjectInputStream ostream = new ObjectInputStream(fout);
            // for(int i=0;i<motivationalShelf.top;i++)
            // {
           motivationalShelf=(Shelf) ostream.readObject();
            ostream.close();
            fout.close();
            System.out.println("data read from file");
            // }
        } catch (Exception e) {
            System.out.println(e);
        }
        return motivationalShelf;
    }
}
