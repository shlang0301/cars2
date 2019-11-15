using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace cars2.Models
{ 
   
    public class AutomobilesData
    {
       

        public int Id { get; set; }

        public int AutomobileId { get; set; }

        public int CarConditionId { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PriceOriginal { get; set; }

        public int? Discount { get; set; }

        public virtual Automobile Automobile { get; set; }

        public virtual CarСonditions CarСonditions { get; set; }
        
        public virtual ICollection<Deal> Deals { get; set; }
    }
}
