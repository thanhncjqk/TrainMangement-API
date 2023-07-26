using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Common.DTO;
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
            if (String.IsNullOrEmpty(record.TrainTripCode))
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

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }
        public override PagingData<Train_Trip> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            if (string.IsNullOrEmpty(search))
            {
                Errors.Add("Missing Schedule ID");
                throw new ValidateException(Errors);
            }
            string where = $"ScheduleID like '{search}'";
            int offSet = (pageNumber - 1) * pageSize;
            return _trainTripDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
