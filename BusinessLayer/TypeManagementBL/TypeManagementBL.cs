using BusinessLayer.BaseBL;
using Common.Entities;
using DataAccessLayer.TypeManagementDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.TypeManagementBL
{
    public class TypeManagementBL : BaseBL<Type_Management>, ITypeManagementBL
    {
        private ITypeManagementDL _typeManagementDL;

        public TypeManagementBL (ITypeManagementDL typeManagementDL) : base (typeManagementDL)
        {
            _typeManagementDL = typeManagementDL;
        }
    }
}
