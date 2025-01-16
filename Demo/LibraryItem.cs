using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class LibraryItem
    {
        #region Properties

        public int ItemId { get; set; }
        public bool IsAvailable { get; set; }

        #endregion

        #region Constructors

        public LibraryItem(int itemId)
        {
            ItemId = itemId;
            IsAvailable = true;
        }

        #endregion

        #region Methods

        public void CheckOut()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Item {ItemId} checked out.");
            }
            else
            {
                Console.WriteLine($"Item {ItemId} is already checked out.");
            }
        }

        public void ReturnItem()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"Item {ItemId} returned.");
            }
            else
            {
                Console.WriteLine($"Item {ItemId} is already available.");
            }

            #endregion
        }
    }
}
