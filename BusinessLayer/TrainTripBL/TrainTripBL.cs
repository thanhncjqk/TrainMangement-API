using BusinessLayer.BaseBL;
using Common.Entities;
using Common.Enum;
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
        List<string> Errors = new List<string>();
        private ITrainTripDL _trainTripDL;

        public TrainTripBL(ITrainTripDL trainTripDL) : base(trainTripDL)
        {
            _trainTripDL = trainTripDL;
        }
        protected override void Validate(Method method, Train_Trip record)
        {
            if (record.TrainTripCode > 0)
            {
                Errors.Add("Missing TrainTripCode");
            }
            if (record.TrainID != null)
            {
                Errors.Add("Missing TrainID");
            }
            if (record.ScheduleID != null)
            {
                Errors.Add("Missing ScheduleID");
            }
            if (record.DepartureTime > DateTime.Now)
            {
                Errors.Add("Missing DepartureTime");
            }
            if (record.ArrivalTime > DateTime.Now)
            {
                Errors.Add("Missing ArrivalTime");
            }
        }
    }
}
