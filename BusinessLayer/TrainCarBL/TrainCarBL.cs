using BusinessLayer.BaseBL;
using Common.Entities;
using DataAccessLayer.TrainCarDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.TrainCarBL
{
    public class TrainCarBL : BaseBL<Train_Car>, ITrainCarBL
    {
        private ITrainCarDL _trainCarDL;

        public TrainCarBL (ITrainCarDL trainCarDL) : base (trainCarDL)
        {
            _trainCarDL = trainCarDL;
        }
    }
}
