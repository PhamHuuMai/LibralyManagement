using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 
namespace LibraryManege.FrameModel
{
    public class PayInfor
    {
        private Reader _reader;
        private IEnumerable _lisBook;

        public Reader Reader
        {
            get
            {
                return _reader;
            }

            set
            {
                _reader = value;
            }
        }
        public IEnumerable LisBook
        {
            get
            {
                return _lisBook;
            }

            set
            {
                _lisBook = value;
            }
        }
    }
}
