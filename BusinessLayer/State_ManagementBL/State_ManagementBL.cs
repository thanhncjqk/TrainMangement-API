using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Common.DTO;
using Common.Entities;
using Common.Enum;
using DataAccessLayer.State_ManagementDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.State_ManagementBL
{
    public class State_ManagementBL : BaseBL<Status>, IState_ManagementBL
    {
        List<string> Errors = new List<string>();
        private IState_ManagementDL _stateManagementDL;

        public State_ManagementBL(IState_ManagementDL stateManagementDL) : base(stateManagementDL)
        {
            _stateManagementDL = stateManagementDL;
        }
        protected override void Validate(Method method, Status record)
        {
            if (String.IsNullOrEmpty(record.TableName))
            {
                Errors.Add("Missing TableName");
            }

            if (String.IsNullOrEmpty(record.StateName))
            {
                Errors.Add("Missing StateName");
            }

            if (String.IsNullOrEmpty(record.Value))
            {
                Errors.Add("Missing Value");
            }

            if (String.IsNullOrEmpty(record.CSSClass))
            {
                Errors.Add("Missing CSSClass");
            }

            if (String.IsNullOrEmpty(record.Sorting))
            {
                Errors.Add("Missing Sorting");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }
        public override PagingData<Status> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            string where = $"StateName like '{search}'";
            int offSet = (pageNumber - 1) * pageSize;
            return _stateManagementDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
