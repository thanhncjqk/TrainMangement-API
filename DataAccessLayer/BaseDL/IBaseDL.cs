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

        public T GetRecordById(Guid id);

        public int DeleteOneRecord(Guid id);

        public Guid InsertOneRecord(T record);

        public Guid UpdateOneRecord(Guid id, T record);

        public int DeleteMutiRecords(List<Guid> ids);

    }
}