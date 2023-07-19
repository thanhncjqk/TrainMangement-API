using BusinessLayer.BaseBL;
using Common.Entities;
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
        private IStationDL _stationDL;

        public StationBL(IStationDL stationDL) : base(stationDL)
        {
            _stationDL = stationDL;
        }
    }
}
