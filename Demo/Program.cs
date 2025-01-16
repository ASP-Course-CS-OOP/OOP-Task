namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Algorithm", "Eslam Elsaadany", "978-3-16-148410-0");
            DateTime borrowDate = new DateTime(2025, 1, 1);
            BorrowedBook borrowedBook = new BorrowedBook(1, book, "Ahmed Ashraf", borrowDate);

            Console.WriteLine($"Book Title: {borrowedBook.BookDetails.Title}");
            Console.WriteLine($"Author: {borrowedBook.BookDetails.Author}");
            Console.WriteLine($"ISBN: {borrowedBook.BookDetails.ISBN}");

            Console.WriteLine($"\nThe {borrowedBook.BookDetails.Title} Book Borrowed at {borrowDate.Day}/{borrowDate.Month}/{borrowDate.Year}!");
            borrowedBook.CheckOut();

            DateTime returnDate = new DateTime(2025, 1, 16);
            int borrowDuration = borrowedBook.CalculateBorrowDuration(returnDate);

            Console.WriteLine($"\nThe {borrowedBook.BookDetails.Title} Book Returned at {returnDate.Day}/{returnDate.Month}/{returnDate.Year}");
            borrowedBook.ReturnItem();
            Console.WriteLine($"\nThe Borrowing Duration is : {borrowDuration} Day");

        }
    }
}
