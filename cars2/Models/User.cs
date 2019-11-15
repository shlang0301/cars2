using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace cars2.Models
{
    

    public class User    {
      

        public int Id { get; set; }

        public int RoleUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserLogin { get; set; }

        [Required]
        [StringLength(50)]
        public string UserPassword { get; set; }

        public virtual ICollection<Deal> Deals { get; set; }

        public virtual RolesUser RolesUser { get; set; }
    }
}
