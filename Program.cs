using System;
//questionNumber-1
#region First Question
class Book
{

    public string title;
    public int pages;

}
#endregion
class Program
{
    static void Main()
    {
        #region First Question


        Book book = new Book();
        book.title = "english";
        book.pages = 10;
        Object obj = book;
        Console.WriteLine(obj);
        #endregion
        #region Second Question

        Console.WriteLine(book.ToString());
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(book.GetType());
        #endregion
        #region Third Question
        /* int pages = "464"; is a string and cannot initlize it to an int;
        int pages = 464;
        */

        #endregion
        #region Fourth Question
        try
        {
            int zero = 0;
            int result = 10 / zero;

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally { Console.WriteLine("Done"); }

        #endregion
        #region Fifth Question
        int pages = 300;
        double pages2 = pages;
        #endregion
    }
}