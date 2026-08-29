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
        #region Sixth Question
        double price = 49.99;
        int price2 = (int)price;

        #endregion
        #region Seventh Question
        string pagesText = "464";
        int pagesText2 = Convert.ToInt32(pagesText);

        #endregion
        #region Eighth Question
        string yearText = "2023";
        int year = int.Parse(yearText);
        string badText = "abc";
        if (int.TryParse(badText, out int num))
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }

        #endregion
        #region Ninth Question
        int pagex = 464;
        string pageText = pagex.ToString();
        Console.WriteLine(pageText.GetType());

        #endregion
        #region Tenth Question
        int copies = 100;
        Object obj2 = copies;
        int unboxedCopies = (int)obj2;

        #endregion
    }
}