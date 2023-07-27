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
            if (record.TrainNumber > 0)
            {
                Errors.Add("Missing TrainNumber");
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
        public override PagingData<Train> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            //if (string.IsNullOrEmpty(search))
            //{
            //    Errors.Add("Missing Train ID");
            //    throw new ValidateException(Errors);
            //}
            //string where = $"sc.ScheduleID like '{search} OR s.StationID like {search}'";

            string where = "";
            if (!string.IsNullOrEmpty(search))
            {
                where = $"sh.ScheduleID like '%{search}%' OR s.StationID like '%{search}%'";
            }
            int offSet = (pageNumber - 1) * pageSize;
            return _trainDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
