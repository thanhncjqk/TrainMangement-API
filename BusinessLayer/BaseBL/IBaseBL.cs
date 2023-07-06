using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BaseBL
{
    public interface IBaseBL<T>
    {
        public PagingData<T> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1);

        public T GetRecordById(Guid id);

        public int DeleteOneRecord(Guid id);

        public Guid InsertOneRecord(T record);

        public Guid UpdateOneRecord(Guid ID, T record);

        public int DeleteMutirecord(List<Guid> ids);
    }
}
    
