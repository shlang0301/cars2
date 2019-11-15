using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace cars2.Models
{    

    public class Equipment
    {      

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string TypeEquipment { get; set; }

        [StringLength(200)]
        public string DescriptionEquipment { get; set; }

      
        public virtual ICollection<Automobile> Automobiles { get; set; }
    }
}
