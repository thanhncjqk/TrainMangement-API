﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class PagingData<T>
    {
        public List<T> Data { get; set; } = new List<T>();
        public long TotalCount { get; set; }
    }
}
