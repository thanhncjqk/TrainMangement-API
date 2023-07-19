using BusinessLayer.BaseBL;
using BusinessLayer.TicketBL;
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
        }
    }
}
