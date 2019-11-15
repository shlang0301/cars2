using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace cars2.Models
{
    public class Deal
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int AutomobileId { get; set; }

        public virtual AutomobilesData AutomobilesData { get; set; }

        public virtual User User { get; set; }
    }
}
