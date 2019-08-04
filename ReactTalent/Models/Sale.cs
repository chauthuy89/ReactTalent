﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReactTalent.Models
{
    public partial class Sale
    {
        [Key]
        public int SaleId { get; set; }
        
        public DateTime DateSold { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int? StoreId { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Store Store { get; set; }
    }
}
