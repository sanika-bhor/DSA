package com.tap.stack.demo;

public class Book {
    public int id;
    public String title;
    public String author;

    public Book()
    {
        this.id=1;
        this.title="Rich dad poor dad";
        this.author="Robert k.";
    }

    public Book(int id, String title, String author)
    {
        this.id=id;
        this.title=title;
        this.author=author;
    }
}
