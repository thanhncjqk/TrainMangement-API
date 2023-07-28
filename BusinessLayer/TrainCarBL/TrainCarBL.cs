using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Common.DTO;
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

            if (record.TrainId != null)
            {
                Errors.Add("Missing TrainID");
            }

            if (record.TypeId != null)
            {
                Errors.Add("Missing TypeID");
            }

            if (record.StatusId != null)
            {
                Errors.Add("Missing StatusID");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }

        public override PagingData<Train_Car> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            if (string.IsNullOrEmpty(search))
            {
                Errors.Add("Missing Train Car Id");
                throw new ValidateException(Errors);
            }
            string where = $"TrainId like '{search}'";
            int offSet = (pageNumber - 1) * pageSize;
            return _trainCarDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
