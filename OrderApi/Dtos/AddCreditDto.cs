﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Dtos
{
    public class AddCreditDto
    {
        public int Credit { get; set; }
        public int CustomerId { get; set; }
    }
}
