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
    public class DangNhapMod
    {
        private LibraryManageEntities4 data;
        public DangNhapMod()
        {
            data = new LibraryManageEntities4();
        }
        public Librarian laydulieutaikhoan(string mkhau,string ten)
        {          
            return  data.Librarians.SingleOrDefault(x=>x.mk.Equals( mkhau )&& x.Name.Equals( ten));
        }
        public IEnumerable allds()
        {
            var ll = from b in data.Librarians
                     
                     select new { b.ID,b.Name,b.mk,b.Birthday,Gioi_Tinh= b.Gender==0?"Nữ":"Nam" };

            return ll.ToList();
        }
        public void delete(Librarian l)
        {
            Librarian li = data.Librarians.Find(l.ID);
            data.Librarians.Remove(li);
            data.SaveChanges();
        }
        public void insert(Librarian l )
        {
            Librarian li = new Librarian();
            li.ID = l.ID;
            li.Name = l.Name;
            li.Gender = l.Gender;
            li.Birthday = l.Birthday;
            li.mk = l.mk;
            data.Librarians.Add(l);
            data.SaveChanges();

        }
        public void update(Librarian l)
        {
            Librarian li = data.Librarians.SingleOrDefault(x => x.ID == l.ID);
            li.ID = l.ID;
            li.Name = l.Name;
            li.Gender = l.Gender;
            li.Birthday = l.Birthday;
            li.mk = l.mk;
            data.SaveChanges();
        }
    }
}
