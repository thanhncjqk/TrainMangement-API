using BusinessLayer.BaseBL;
using Common.Entities;
using DataAccessLayer.TrainDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.TrainBL
{
    public class TrainBL : BaseBL<Train>, ITrainBL
    {
        private ITrainDL _trainDL;

        public TrainBL (ITrainDL trainDL) : base(trainDL)
        {
            _trainDL = trainDL;
        }
        
    }
}
