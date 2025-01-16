namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char needBorrow;
            bool BorrowParsed;
            do
            {
                Console.Write("\nYou Need To Borrow Book [y/n] : ");
                BorrowParsed = char.TryParse(Console.ReadLine(), out needBorrow);
            } while (!BorrowParsed || (needBorrow != 'y' && needBorrow != 'n'));

            int id;
            bool idParsed;
            if (needBorrow == 'y')
            {
                do
                {
                    Console.Write("\nEnter Book Id : ");
                    idParsed = int.TryParse(Console.ReadLine(), out id);
                } while (!idParsed);

                Console.WriteLine("\nEnter Book Detail => ");

                bool titleIsNullOrWhiteSpace;
                string title;
                do
                {
                    Console.Write("Title : ");
                    title = Console.ReadLine()!;
                    titleIsNullOrWhiteSpace = string.IsNullOrWhiteSpace(title);
                } while (titleIsNullOrWhiteSpace);

                bool authorIsNullOrWhiteSpace;
                string author;
                do
                {
                    Console.Write("Author : ");
                    author = Console.ReadLine()!;
                    authorIsNullOrWhiteSpace = string.IsNullOrWhiteSpace(author);
                } while (authorIsNullOrWhiteSpace);

                bool isbnIsNullOrWhiteSpace;
                string isbn;
                do
                {
                    Console.Write("ISBN : ");
                    isbn = Console.ReadLine()!;
                    isbnIsNullOrWhiteSpace = string.IsNullOrWhiteSpace(isbn);
                } while (isbnIsNullOrWhiteSpace);


                bool nameIsNullOrwhiteSpace;
                string name;
                do
                {
                    Console.Write("\nEnter Your Name : ");
                    name = Console.ReadLine()!;
                    nameIsNullOrwhiteSpace = string.IsNullOrWhiteSpace(name);
                } while (nameIsNullOrwhiteSpace);

                int day, month, year;
                bool BorrowDayParsed, BorrowMonthParsed, BorrowYearParsed;
                Console.WriteLine("\nEnter Borrowing Date => ");

                do
                {
                    Console.Write("Day: ");
                    BorrowDayParsed = int.TryParse(Console.ReadLine(), out day);
                } while (!BorrowDayParsed || day > 31 || day < 0);

                do
                {
                    Console.Write("Month: ");
                    BorrowMonthParsed = int.TryParse(Console.ReadLine(), out month);
                } while (!BorrowMonthParsed || month > 12 || month < 0);

                do
                {
                    Console.Write("Year: ");
                    BorrowYearParsed = int.TryParse(Console.ReadLine(), out year);
                } while (!BorrowYearParsed || year > 2025);

                DateTime borrowedDate = new DateTime(year, month, day);
                Book book = new Book(title, author, isbn);
                BorrowedBook borrowedBook = new BorrowedBook(id, book, name, borrowedDate);

                Console.WriteLine("=========================================================");
                Console.WriteLine("Data Of Borrowed Book => ");
                Console.Write($"Id:{borrowedBook.ItemId}, Title:{borrowedBook.BookDetails.Title}, Author:{borrowedBook.BookDetails.Author}, ISBN:{borrowedBook.BookDetails.ISBN}, BorrowedDate: {borrowedDate.Day}/{borrowedDate.Month}/{borrowedDate.Year}, Availability: {borrowedBook.IsAvailable}.\n");

                borrowedBook.CheckOut();

                Console.WriteLine("=========================================================");
                char needReturn;
                bool ReturnParsed;
                do
                {
                    Console.Write("\n\nYou Need To Return Book [y/n] : ");
                    ReturnParsed = char.TryParse(Console.ReadLine(), out needReturn);
                } while (!ReturnParsed || (needReturn != 'y' && needReturn != 'n'));

                if (needReturn == 'y')
                {
                    bool ReturnDayParsed, ReturnMonthParsed, ReturnYearParsed;

                    Console.WriteLine("\nEnter The Returned Date => ");
                    do
                    {
                        Console.Write("Day: ");
                        ReturnDayParsed = int.TryParse(Console.ReadLine(), out day);
                    } while (!ReturnDayParsed);

                    do
                    {
                        Console.Write("Month: ");
                        ReturnMonthParsed = int.TryParse(Console.ReadLine(), out month);
                    } while (!ReturnMonthParsed);

                    do
                    {
                        Console.Write("Year: ");
                        ReturnYearParsed = int.TryParse(Console.ReadLine(), out year);
                    } while (!ReturnYearParsed);

                    DateTime returnDate = new DateTime(year, month, day);
                    int borrowDuration = borrowedBook.CalculateBorrowDuration(returnDate);

                    Console.WriteLine("=========================================================");
                    Console.WriteLine($"The Borrowing Duration Of This {borrowedBook.BookDetails.Title} Book is {borrowDuration} Day!");

                    borrowedBook.ReturnItem();

                    Console.WriteLine("=========================================================");
                    Console.WriteLine("Data Of Returned Book => ");
                    Console.Write($"Id:{borrowedBook.ItemId}, Title:{borrowedBook.BookDetails.Title}, Author:{borrowedBook.BookDetails.Author}, ISBN:{borrowedBook.BookDetails.ISBN}, ReturnedDate: {returnDate.Day}/{returnDate.Month}/{returnDate.Year}, Availability: {borrowedBook.IsAvailable}.\n");
                    Console.WriteLine("=========================================================");

                }
            }
        }
    }
}
