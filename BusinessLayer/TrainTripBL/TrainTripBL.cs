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

namespace BusinessLayer
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

            if (record.DepartureStation != null)
            {
                Errors.Add("Missing DepartureStation");
            }

            if (record.ArrivalStation != null)
            {
                Errors.Add("Missing ArrivalStation");
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
        public PagingData<Train_Trip> FilterTrainDateTime (DateTime DepartureTime, DateTime ArrivalTime, int DepartureStation, int ArrivalStation, int pageSize = 10, int pageNumber = 1)
        {
            if (DepartureStation != null)
            {
                Errors.Add("Missing Schedule ID");
                throw new ValidateException(Errors);
            }
            if (ArrivalStation != null)
            {
                Errors.Add("Missing Schedule ID");
                throw new ValidateException(Errors);
            }
            if (DepartureTime != null)
            {
                Errors.Add("Missing Schedule ID");
                throw new ValidateException(Errors);
            }
            if (ArrivalTime != null)
            {
                Errors.Add("Missing Schedule ID");
                throw new ValidateException(Errors);
            }
            string where = $"DepartureStation like '{DepartureStation}' AND ArrivalStation like '{ArrivalStation}' AND DepartureTime like '{DepartureTime}' AND ArrivalTime like '{ArrivalTime}'";
            int offSet = (pageNumber - 1) * pageSize;
            return _trainTripDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }

        public PagingData<Train_Trip> FilterTrain(DateTime DepartureTime, DateTime ArrivalTime, int DepartureStation, int ArrivalStation, int pageSize = 10, int pageNumber = 1)
        {
            throw new NotImplementedException();
        }
    }
}
