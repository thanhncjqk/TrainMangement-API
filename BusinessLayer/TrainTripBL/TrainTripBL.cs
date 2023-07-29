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
    public class TrainTripBL : BaseBL<TrainTrip>, ITrainTripBL
    {
        List<string> Errors = new List<string>();
        private ITrainTripDL _trainTripDL;

        public TrainTripBL(ITrainTripDL trainTripDL) : base(trainTripDL)
        {
            _trainTripDL = trainTripDL;
        }
        protected override void Validate(Method method, TrainTrip record)
        {
            if (String.IsNullOrEmpty(record.TrainTripCode))
            {
                Errors.Add("Missing TrainTripCode");
            }

            if (record.TrainId == null)
            {
                Errors.Add("Missing TrainID");
            }

            if (record.ScheduleId == null)
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
    
        public PagingData<TrainTrip> FilterTrain(FilterTime filterTime)
        {
            string where = $"tt.DepartureTime >= '{formatDatetime(filterTime.DepartureTime)}' AND tt.DepartureTime <= '{formatDatetime(filterTime.ArrivalTime)}'";
            int offSet = (filterTime.Page - 1) * filterTime.PageSize;
            return _trainTripDL.GetFilterRecords(where, "tt.ModifiedDate DESC", offSet, filterTime.PageSize);
        }
    }
}
