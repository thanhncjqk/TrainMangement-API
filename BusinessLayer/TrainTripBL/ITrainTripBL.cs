using BusinessLayer.BaseBL;
using Common.DTO;
using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  interface ITrainTripBL : IBaseBL<TrainTrip>
    {
        public PagingData<TrainTrip> FilterTrain(FilterTime filterTime);
    }
}
