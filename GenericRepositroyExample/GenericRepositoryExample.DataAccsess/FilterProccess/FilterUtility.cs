﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryExample.DataAccsess.FilterProccess

{
    public class FilterUtility
    {
        public enum FilterOptions
        {
            StartsWith = 1,
            EndsWith,
            Contains,
            DoesNotContain,
            IsEmpty,
            IsNotEmpty,
            IsGreaterThan,
            IsGreaterThanOrEqualto,
            IsLessThan,
            IsLessThanOrEqualTo,
            IsEqualTo,
            IsNotEqualTo

        }
    }
}
