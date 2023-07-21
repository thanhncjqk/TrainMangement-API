using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Common.Entities;
using Common.Enum;
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
        List<string> Errors = new List<string>();
        private ITrainCarDL _trainCarDL;

        public TrainCarBL (ITrainCarDL trainCarDL) : base (trainCarDL)
        {
            _trainCarDL = trainCarDL;
        }
        protected override void Validate(Method method, Train_Car record)
        {
            if (record.TrainCarNumber > 0)
            {
                Errors.Add("Missing TrainNumber");
            }

            if (record.TrainID != null)
            {
                Errors.Add("Missing TrainID");
            }

            if (record.TypeID != null)
            {
                Errors.Add("Missing TypeID");
            }

            if (record.StatusID != null)
            {
                Errors.Add("Missing StatusID");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }
    }
}
