using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
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
    public class State_ManagementBL : BaseBL<State_Management>, IState_ManagementBL
    {
        List<string> Errors = new List<string>();
        private IState_ManagementDL _stateManagementDL;

        public State_ManagementBL(IState_ManagementDL stateManagementDL) : base(stateManagementDL)
        {
            _stateManagementDL = stateManagementDL;
        }
        protected override void Validate(Method method, State_Management record)
        {
            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }
    }
}
