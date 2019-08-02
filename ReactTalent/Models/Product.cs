using System;
using System.Collections.Generic;

namespace ReactTalent.Models
{
    public partial class Product
    {
        public Product()
        {
            Sale = new HashSet<Sale>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public ICollection<Sale> Sale { get; set; }
    }
}
