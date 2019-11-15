using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cars2.Models
{
    public class Cars2DbInitializer : DropCreateDatabaseAlways<Model1>
    {
        protected override void Seed(Model1 db)
        {

            db.CarModels.Add ( new CarModel { CarModel1 = "Fiat"});

            db.CarСonditions.Add(new CarСonditions { CarСondition = "good"});

            db.Colors.Add(new Color { Color1 = "red" });

            db.Drives.Add(new Drive {  TypeDrive = "mechanic" });

            db.Engines.Add(new Engines { Engine = "diesel" });

            base.Seed(db);
        }
    }
}