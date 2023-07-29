using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Common.DTO;
using Common.Entities;
using Common.Enum;
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
        List<string> Errors = new List<string>();
        private ITypeManagementDL _typeManagementDL;

        public TypeManagementBL (ITypeManagementDL typeManagementDL) : base (typeManagementDL)
        {
            _typeManagementDL = typeManagementDL;
        }
        protected override void Validate(Method method, Type_Management record)
        {
            if (String.IsNullOrEmpty(record.TypeName))
            {
                Errors.Add("Missing TypeName");
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

            if (record.StateId == null)
            {
                Errors.Add("Missing StateId");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }
        public override PagingData<Type_Management> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            string where = $"TypeName like '{search}'";
            int offSet = (pageNumber - 1) * pageSize;
            return _typeManagementDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
