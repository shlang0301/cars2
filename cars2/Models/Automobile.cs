using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace cars2.Models
{   

    public  class Automobile
    {
       
        public int Id { get; set; }

        public int CarModelId { get; set; }

        public int ColorId { get; set; }

        public int DriveId { get; set; }

        public int EngineId { get; set; }

        public int EquipmentId { get; set; }

        public int TransmissionId { get; set; }

        public int TypeAutoId { get; set; }

        public byte[] Photo { get; set; }

        
        public virtual ICollection<AutomobilesData> AutomobilesDatas { get; set; }

        public virtual CarModel CarModel { get; set; }

        public virtual Color Color { get; set; }

        public virtual Drive Drive { get; set; }

        public virtual Engines Engine { get; set; }

        public virtual Equipment Equipment { get; set; }

        public virtual Transmission Transmission { get; set; }

        public virtual TypesAuto TypesAuto { get; set; }
    }
}
