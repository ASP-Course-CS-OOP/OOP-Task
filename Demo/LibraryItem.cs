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
        }

        #endregion

        #region Methods

        public void CheckOut()
        {
            IsAvailable = false;
        }
        public void ReturnItem()
        {
            IsAvailable = true;
        }

        #endregion
    }
}
