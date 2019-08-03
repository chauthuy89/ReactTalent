﻿using System;
using System.Collections.Generic;

namespace ReactTalent.Models
{
    public partial class Customer
    {     

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Sale> Sale { get; set; }
    }
}