﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InetMarket.Models
{
    public class FilterListView
    {
        public ICollection<Filter> Filters { get; set; }
        public SelectList Categories { get; set; }
    }
}