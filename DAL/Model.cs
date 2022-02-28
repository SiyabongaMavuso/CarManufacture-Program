using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Model
    {
        public int ModelID { get; set; }
        public string ModelDescription { get; set; }
        public int ManufacturerID { get; set; }
        public string ManufacturerDescription { get; set; }

        public Model()
        {

        }

        public Model(int modelID, string modelDescription, int manufacturerID, string manufacturerDescription)
        {
            this.ModelID = modelID;
            this.ModelDescription = modelDescription;
            this.ManufacturerID = manufacturerID;
            this.ManufacturerDescription = manufacturerDescription;
        }
    }
}
