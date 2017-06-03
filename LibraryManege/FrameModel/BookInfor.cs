using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManege.Model; 
namespace LibraryManege.FrameModel
{
    public class BookInfor
    {
        private Header _header;
        private int _countAll;
        private int _countRemaining;

        public Header Header
        {
            get
            {
                return _header;
            }
        }

        public int CountAll
        {
            get
            {
                return _countAll;
            }
        }

        public int CountRemaining
        {
            get
            {
                return _countRemaining;
            }
        }
        public BookInfor(int id)
        {
            _countAll = (new BookModel()).CountBook(id);
            _countRemaining = (new BookModel()).CountBookRemaining(id);
            _header = (new BookModel()).GetHeader(id);
        }
             
    }
}
