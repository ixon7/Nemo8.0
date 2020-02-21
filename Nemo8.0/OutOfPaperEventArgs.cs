using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo8._0
{
    public class OutOfPaperEventArgs : EventArgs
    {
        public OutOfPaperEventArgs(int pageNumber)
        {
            PageNumber = pageNumber;
        }
        public int PageNumber { get; } // właśiwość funkcji 
    }
}
