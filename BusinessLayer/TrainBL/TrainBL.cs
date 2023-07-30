using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using BusinessLayer.TicketBL;
using Common.DTO;
using Common.Entities;
using Common.Enum;
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
        List<string> Errors = new List<string>();
        private ITrainDL _trainDL;

        public TrainBL (ITrainDL trainDL) : base(trainDL)
        {
            _trainDL = trainDL;
        }

        protected override void Validate(Method method, Train record)
        {
            if (record.TrainNumber == null)
            {
                Errors.Add("Missing TrainNumber");
            }

            if (record.TypeId == null)
            {
                Errors.Add("Missing TypeID");
            }

            if (record.StatusId == null)
            {
                Errors.Add("Missing StatusID");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }
        public override PagingData<Train> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            string where = "";
            if (!string.IsNullOrEmpty(search))
            {
                where = $"s.ScheduleName like '{search}'";
            }
            int offSet = (pageNumber - 1) * pageSize;
            return _trainDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
