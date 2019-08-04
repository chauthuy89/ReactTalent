using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReactTalent.Models
{
    public partial class Customer
    {     
      
       
        public Customer()
        {
            Sale = new HashSet<Sale>();
        }
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Sale> Sale { get; set; }
    }
}
