﻿using BusinessLayer.BaseBL;
using Common.DTO;
using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  interface ITrainTripBL : IBaseBL<Train_Trip>
    {
        public PagingData<Train_Trip> FilterTrain(DateTime DepartureTime, DateTime ArrivalTime, int DepartureStation, int ArrivalStation, int pageSize = 10, int pageNumber = 1);
    }
}
