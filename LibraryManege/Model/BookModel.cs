using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using LibraryManege.FrameModel;
using LibraryManege;
namespace LibraryManege.Model
{
    public class BookModel
    {
        private LibraryManageEntities3 data;
        public BookModel()
        {
            data = new LibraryManageEntities3();
        }
        public IEnumerable GetBookByReader(int id)
        {
            var ll = from b in data.Borrows
                     join bo in data.Books on b.IDBook equals bo.ID
                     join h in data.Headers on bo.IDHeader equals h.ID
                     where b.IDReader == id
                     select new
                     {
                         hh= bo.ID,
                         h.Name,
                         h.Authors,
                         b.Date,
                         b.ExpertDate,
                         bo.Quantity                 
                     };
            return ll.ToList();
        }

        public bool checkBook(int idBook)
        {
            var dd = from i in data.Borrows
                     select i.IDBook;
            var ff = from f in data.Books
                     select f.ID;
            var ee= ff.Except(dd);
            return ee.Contains(idBook); 
        }
        public int BorrowBook(int idPerson,int idBook,int idLib)
        {
            try
            {
                Object[] param = { idBook };
                if (data.Borrows.Find(param).IDReader == idPerson)
                {
                    data.Borrows.Remove(data.Borrows.Find(param));
                    data.SaveChanges();
                    return 1;
                }
            }catch(Exception ee)
            {
                if (checkBook(idBook)) {
                        Borrow br = new Borrow();
                        br.IDBook = idBook;
                        br.IDLibrarian = idLib;
                        br.IDReader = idPerson;
                        br.Date = DateTime.Now;
                        br.ExpertDate = DateTime.Now.AddMonths(5);
                        data.Borrows.Add(br);
                        data.SaveChanges();
                    return 0;
                }
                throw ee;
            }
            return -1;
        }
        public PayInfor PayBook(int idBook)
        {
            PayInfor pi = new PayInfor();
            if (!checkBook(idBook)) {
                Object[] param = { idBook };
                pi.Reader = data.Borrows.Find(param).Reader;
                data.Borrows.Remove(data.Borrows.Find(idBook));
                data.SaveChanges();
                pi.LisBook = GetBookByReader(pi.Reader.ID);
                return pi;
            }
            return null;
        }
        public IEnumerable SeachHeaderBook(String key)
        {
            var re = from h in data.Headers
                     where h.Name.Contains(key) || h.Authors.Contains(key)
                     select new
                     {
                         h.ID,
                         h.Name,
                         h.Authors,
                         NXB = h.NhaXB.Name
                     };
            return re.ToList();
        }
        public int CountBookRemaining(int idHeader)
        {
            var all = from b in data.Books
                      where b.IDHeader==idHeader
                      select b;
            var remaining= from b in data.Borrows
                           where b.Book.IDHeader == idHeader
                           select b;
            return all.Count()-remaining.Count();
        }
        public int CountBook(int idHeader)
        {
            var all = from b in data.Books
                      where b.IDHeader == idHeader
                      select b;
            return all.Count(); 
        }
        public Header GetHeader(int id)
        {
            return (from h in data.Headers
                    where h.ID == id
                    select h).FirstOrDefault();
        }
    }
}
