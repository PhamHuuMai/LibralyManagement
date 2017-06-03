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
    public class dausachMod
    {
        private LibraryManageEntities3 data;
        public dausachMod()
        {
            data = new LibraryManageEntities3();
        }
        public IEnumerable load()
        {
            return (from h in data.Headers join y in data.NhaXBs on h.IDNXB equals y.ID
                    select new { h.ID,h.Name,h.Date,h.Version,TenNXB= y.Name,h.Authors,h.Type,h.PageNumber }
                    ).ToList();
        }
        public IEnumerable laydulieutheokeyword(string keyword)
        {
            return (from b in data.Headers  join y in data.NhaXBs on b.IDNXB equals y.ID
                    where b.Name.Contains(keyword)
                    select new { b.ID, b.Name, b.Date, b.Version,TenNXB= b.Name, b.Authors, b.Type, b.PageNumber }          
                    ).ToList();
        }
        public void delete(Header l)
        {
            Header li = data.Headers.Find(l.ID);
            data.Headers.Remove(li);
            data.SaveChanges();
        }
        public void insert(Header l)
        {
            Header li = new Header();
            li.ID = l.ID;
            li.Name = l.Name;
            li.Date = l.Date;
            li.Version = l.Version;
            li.IDNXB = l.IDNXB;
            li.Type = l.Type;
            li.Authors = l.Authors;
            li.PageNumber = l.PageNumber;
          
            data.Headers.Add(l);
            data.SaveChanges();

        }
        public void update(Header l)
        {
            Header li = data.Headers.SingleOrDefault(x => x.ID == l.ID);
            li.ID = l.ID;
            li.Name = l.Name;
            li.Date = l.Date;
            li.Version = l.Version;
            li.IDNXB = l.IDNXB;
            li.Type = l.Type;
            li.Authors = l.Authors;
            li.PageNumber = l.PageNumber;
            data.SaveChanges();
        }
    }
}
