﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ViewModels
{
    public class CustomerSearchViewModel
    {
        public int CustomerId { get; set; }
        public string PersonalNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }


    }
}
