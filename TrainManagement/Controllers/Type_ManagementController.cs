using BusinessLayer.TypeManagementBL;
using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Type_ManagementController : BasesController<Common.Entities.Type>
    {
        private ITypeManagementBL _typeManagementBL;

        public Type_ManagementController(ITypeManagementBL typeManagementBL) : base(typeManagementBL) 
        {
            _typeManagementBL = typeManagementBL;
        }
    }
}
