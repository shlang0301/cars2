using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace cars2.Models
{    

    public class Transmission
    {
      
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string TypeTransmission { get; set; }

       
        public virtual ICollection<Automobile> Automobiles { get; set; }
    }
}
