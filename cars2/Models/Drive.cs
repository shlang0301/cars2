using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace cars2.Models
{

    public class Drive
    {
       

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string TypeDrive { get; set; }

        public virtual ICollection<Automobile> Automobiles { get; set; }
    }
}
