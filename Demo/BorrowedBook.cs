using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class BorrowedBook:LibraryItem
    {
        #region Properties

        public Book BookDetails { get; set; }
        public string BorrowerName { get; set; }
        public DateTime BorrowedDate { get; set; }

        #endregion

        #region Constructors

        public BorrowedBook(int id, Book bookDetails, string borrowerName, DateTime borrowedDate) : base(id)
        {
            BookDetails = bookDetails;
            BorrowerName = borrowerName;
            BorrowedDate = borrowedDate;
            IsAvailable = false;
        }

        #endregion

        #region Methods

        public int CalculateBorrowDuration(DateTime returnDate)
        {
            IsAvailable = true;
            return returnDate.Day - BorrowedDate.Day;
        }

        #endregion
    }
}
