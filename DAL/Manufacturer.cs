using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class Manufacturer
    {
        public int ManufacturerID { get; set; }
        public string ManufacturerDescription { get; set; }
        public string ManufacturerLocation { get; set; }
        public string ContactPerson { get; set; }

        public Manufacturer()
        {

        }

        public Manufacturer(int manufacturerID, string manufacturerDescription, string manufacturerLocation, string contactPerson)
        {
            this.ManufacturerID = manufacturerID;
            this.ManufacturerDescription = manufacturerDescription;
            this.ManufacturerLocation = manufacturerLocation;
            this.ContactPerson = contactPerson;
        }
    }
}
