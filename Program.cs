using System;
//questionNumber-1
class Book
{

    public string title;
    public int pages;

}
class Program
{
    static void Main()
    {

        Book book = new Book();
        book.title = "english";
        book.pages = 10;
        Object obj = book;
        Console.WriteLine(obj);
    }
}