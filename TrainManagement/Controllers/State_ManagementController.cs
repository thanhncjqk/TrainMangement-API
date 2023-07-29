using BusinessLayer.State_ManagementBL;
using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class State_ManagementController : BasesController<Status>
    {
        private IState_ManagementBL _stateManagementBL;

        public State_ManagementController(IState_ManagementBL stateManagementBL) : base(stateManagementBL)
        {
            _stateManagementBL = stateManagementBL;
        }
    }
}
