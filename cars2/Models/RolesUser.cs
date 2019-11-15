using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace cars2.Models
{
    

    public class RolesUser
    {
      
        public RolesUser()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string RoleUser { get; set; }

       
        public virtual ICollection<User> Users { get; set; }
    }
}
