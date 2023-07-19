using BusinessLayer.BaseBL;
using Common.Entities;
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
        private IState_ManagementDL _stateManagementDL;

        public State_ManagementBL(IState_ManagementDL stateManagementDL) : base(stateManagementDL)
        {
            _stateManagementDL = stateManagementDL;
        }
    }
}
