using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManege;
using System.Collections;

namespace LibraryManege.Model
{
   public class ReaderModel
    {
        private LibraryManageEntities3 data;
        public ReaderModel()
        {
            data = new LibraryManageEntities3();
        }
        public Reader GetReaderById(int id)
        {
            var r = from i in data.Readers
                    where i.ID == id
                    select i;
            return r.FirstOrDefault();
        }
        public IEnumerable SeachReader(String key)
        {
            var r = from i in data.Readers
                    where i.ID.ToString().Contains(key) || i.FullName.Contains(key)
                    select new {
                        i.ID,
                        i.FullName,
                        GT = i.Gender == 1 ? "Nam" : "Nữ",
                        i.Birthday
                    };
            return r.ToList();
        } 
        public void AddReader(Reader re)
        {
            data.Readers.Add(re);
            data.SaveChanges();
        }
        public void UpdateReader(Reader re)
        {
            Reader temp= data.Readers.Find(re.ID);
          //  data.Readers.
            temp.Birthday = re.Birthday;
            temp.Class = re.Class;
            temp.ExpDate = re.ExpDate;
            temp.FullName = re.FullName;
            temp.Gender = re.Gender;
            temp.Images = re.Images;
            temp.InitDate = re.InitDate;
            temp.Note = re.Note;
            data.SaveChanges();
        }
        public void DeleteReader(int id)
        {
            try
            {
                data.Readers.Remove(data.Readers.Find(id));
                data.SaveChanges();
            }
            catch
            {
                throw new Exception("Không thể xóa người đọc này được");
            }
        }
    }
}
