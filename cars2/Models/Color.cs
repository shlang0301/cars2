using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace cars2.Models
{   

    public class Color
    {       
        
        public int Id { get; set; }

        [Column("Color")]
        [Required]
        [StringLength(20)]
        public string Color1 { get; set; }
      
        public virtual ICollection<Automobile> Automobiles { get; set; }
    }
}
