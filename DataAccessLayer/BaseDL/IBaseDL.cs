using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.BaseDL
{
    public interface IBaseDL<T>
    {
        public PagingData<T> GetFilterRecords(string? search, string? sort, int offSet = 0, int limit = 10);

        public T GetRecordById(int id);

        public int DeleteOneRecord(int id);

        public int InsertOneRecord(T record);

<<<<<<< HEAD
        public int UpdateOneRecord(int id, T record);
=======
        public Guid UpdateOneRecord(int id, T record);
>>>>>>> 586436f95fa7d2beb13283242258d403c4dd3ff6

        public int DeleteMutiRecords(List<int> ids);

    }
}