﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class DiscountCard
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool AppliesToFirstClass { get; set; }
    }
}
