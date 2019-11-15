using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace cars2.Models
{
    public class CarModel
    {
        
        public int Id { get; set; }

        [Column("CarModel")]
        [Required]
        [StringLength(20)]
        public string CarModel1 { get; set; }

        
        public virtual ICollection<Automobile> Automobiles { get; set; }
    }
}
