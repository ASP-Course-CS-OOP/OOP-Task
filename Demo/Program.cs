namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Algorithm", "Eslam Elsaadany", "978-3-16-148410-0");
            DateTime borrowDate = new DateTime(2025, 1, 1);
            BorrowedBook borrowedBook = new BorrowedBook(1, book, "Ahmed Ashraf", borrowDate);

            Console.WriteLine($"The {borrowedBook.BookDetails.Title} Book Borrowed!");
            if (!borrowedBook.IsAvailable)
            {
                Console.WriteLine($"{book.Title} Book Is Not Available");
            }

            DateTime returnDate = new DateTime(2025, 1, 16);
            int borrowDuration = borrowedBook.CalculateBorrowDuration(returnDate);

            Console.WriteLine($"The {borrowedBook.BookDetails.Title} Book Returned!");
            Console.WriteLine($"The Borrowing Duration is : {borrowDuration} Day");

            if (borrowedBook.IsAvailable)
            {
                Console.WriteLine($"{book.Title} Book Is Available");
            }
        }
    }
}
