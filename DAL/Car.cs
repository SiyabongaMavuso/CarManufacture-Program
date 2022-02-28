using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Car
    {
        public int CarID { get; set; }
        public string ManufacturerDescription { get; set; }
        public int ManufacturerID { get; set; }

        public string ModelDescription { get; set; }

        public string CarDescription { get; set; }
        public string ReleaseYear { get; set; }

        public double Price { get; set; }

        public Car()
        {

        }

        public Car(int carID, string manufacturerDescription, int manufacturerID, string modelDescription, string carDescription, string releaseYear, double price)
        {
            this.CarID = carID;
            this.ManufacturerDescription = manufacturerDescription;
            this.ManufacturerID = manufacturerID;
            this.ModelDescription = modelDescription;
            this.CarDescription = carDescription;
            this.ReleaseYear = releaseYear;
            this.Price = price;
        }
    }
}
