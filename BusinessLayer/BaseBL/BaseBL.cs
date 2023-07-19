﻿using Common.DTO;
using Common.Enum;
using DataAccessLayer.BaseDL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.BaseBL
{
    public class BaseBL<T> : IBaseBL<T>
    {
        private IBaseDL<T> _baseDL;
        

        public BaseBL(IBaseDL<T> baseDL)
        {
            _baseDL = baseDL;
        }
        public int DeleteMutirecord(List<Guid> ids)
        {
            return _baseDL.DeleteMutiRecords(ids);
        }

        public int DeleteOneRecord(Guid id)
        {
            return _baseDL.DeleteOneRecord(id);
        }

        public virtual PagingData<T> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            int offSet = (pageNumber - 1) * pageSize;
            return _baseDL.GetFilterRecords(search, "ModifiedDate DESC", offSet, pageSize);
        }

        public T GetRecordById(Guid id)
        {
            return _baseDL.GetRecordById(id);
        }

        public Guid InsertOneRecord(T record)
        {
            Validate(Method.Add, record);
            return _baseDL.InsertOneRecord(record);
        }

        public Guid UpdateOneRecord(Guid ID, T record)
        {
            string className = typeof(T).Name;
            var primaryKeyProp = typeof(T).GetProperties().FirstOrDefault(prop => prop.GetCustomAttributes(typeof(KeyAttribute), true).Count() > 0);

            if (primaryKeyProp != null)
            {
                primaryKeyProp.SetValue(record, ID);
            }

            Validate(Method.Edit, record);
            return _baseDL.UpdateOneRecord(ID, record);
        }
        protected virtual void Validate(Method method, T record)
        {

        }
        public static bool isEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                return false;
            }
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
    }
}
    