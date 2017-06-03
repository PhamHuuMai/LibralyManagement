using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManege.Model
{
    public class NhaXuatBanMod
    {
        private LibraryManageEntities4 data;
        public NhaXuatBanMod()
        {
            data = new LibraryManageEntities4();
        }
        //public Librarian laydulieutaikhoan(string mkhau, string ten)
        //{
        //    return data.Librarians.SingleOrDefault(x => x.mk.Equals(mkhau) && x.Name.Equals(ten));
        //}
        public IEnumerable getAllds()
        {
            var ll = from b in data.NhaXBs
                     select b;

            return ll.ToList();
        }
    }
}
