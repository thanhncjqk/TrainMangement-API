using BusinessLayer.BaseBL;
using Common.Entities;
using DataAccessLayer.TrainCarDL;
using DataAccessLayer.TrainTripDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.TrainTripBL
{
    public class TrainTripBL : BaseBL<Train_Trip>, ITrainTripBL
    {
        private ITrainTripDL _trainTripDL;

        public TrainTripBL(ITrainTripDL trainTripDL) : base(trainTripDL)
        {
            _trainTripDL = trainTripDL;
        }
    }
}
