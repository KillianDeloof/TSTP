﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppHowest.Models.Filters
{
    public class BaseFilter
    {
        public int PageSize { get; set; } = 50;
        public int EffectivePageSize
        {
            get
            {
                if (PageSize < 1) return 1;
                if (PageSize > 100) return 100;
                return PageSize;
            }
        }
    }
}
