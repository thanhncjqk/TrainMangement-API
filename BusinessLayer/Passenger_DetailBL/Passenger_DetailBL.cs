using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Common.DTO;
using Common.Entities;
using Common.Enum;
using DataAccessLayer.Passenger_DetailDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Passenger_DetailBL
{
    public class Passenger_DetailBL : BaseBL<Passenger_Detail>, IPassenger_DetailBL
    {
        List<string> Errors = new List<string>();
        private IPassenger_DetailDL _passengerDetailDL;

        public Passenger_DetailBL(IPassenger_DetailDL passenger_deatilDL) : base(passenger_deatilDL)
        {
            _passengerDetailDL = passenger_deatilDL;
        }

        protected override void Validate(Method method, Passenger_Detail record)
        {
            if (String.IsNullOrEmpty(record.Name))
            {
                Errors.Add("Missing Name");
            }

            if (record.Age != null)
            {
                Errors.Add("Missing Age");
            }

            if (record.Gender != null)
            {
                Errors.Add("Missing gender");
            }

            if (String.IsNullOrEmpty(record.Email))
            {
                Errors.Add("Missing Email");
            }

            if (String.IsNullOrEmpty(record.Password))
            {
                Errors.Add("Missing Password");
            }

            if (String.IsNullOrEmpty(record.Number))
            {
                Errors.Add("Missing number");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }   
        }
        public override PagingData<Passenger_Detail> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            string where = $"Name like '{search}'";
            int offSet = (pageNumber - 1) * pageSize;
            return _passengerDetailDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
