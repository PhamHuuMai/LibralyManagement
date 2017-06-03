using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using LibraryManege.Model;
namespace LibraryManege.FrameModel
{
    public class BorrowInfor
    {
        private Reader _reader;
        private IEnumerable _listBook;

        public Reader Reader
        {
            get
            {
                return _reader;
            }
        }

        public IEnumerable ListBook
        {
            get
            {
                return _listBook;
            }
        }

        public BorrowInfor(int id)
        {
            _reader = (new ReaderModel()).GetReaderById(id);
            _listBook = (new BookModel()).GetBookByReader(id);
        }


    }
}
