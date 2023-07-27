using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Common.DTO;
using Common.Entities;
using Common.Enum;
using DataAccessLayer.StationDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.StationBL
{
    public class StationBL : BaseBL<Station>, IStationBL
    {
        List<string> Errors = new List<string>();
        private IStationDL _stationDL;

        public StationBL(IStationDL stationDL) : base(stationDL)
        {
            _stationDL = stationDL;
        }
        protected override void Validate(Method method, Station record)
        {
            if (String.IsNullOrEmpty(record.StationName))
            {
                Errors.Add("Missing StationName");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }

        public override PagingData<Station> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            string where = "";
            if (string.IsNullOrEmpty(search))
            {
                where = $"StationName like '{search}'";

            }
            int offSet = (pageNumber - 1) * pageSize;
            return _stationDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
