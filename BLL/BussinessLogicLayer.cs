using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BussinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();
        public int InsertManufacturer(Manufacturer manufacturer)
        {
            return dal.InsertManufacturer(manufacturer);
        }
        public DataTable GetManufacturer()
        {
            return dal.GetManufacturer();
        }
        public DataTable GetManufactureByID(int manufacturerID)
        {
            return dal.GetManufactureByID(manufacturerID);
        }
        public int UpdateManufacture(Manufacturer manufacture)
        {
            return dal.UpdateManufacture(manufacture);
        }
        public int InsertModel(Model model)
        {
            return dal.InsertModel(model);
        }
        public DataTable GetModel()
        {
            return dal.GetModel();
        }
        public DataTable GetModelByID(int modelID)
        {
            return dal.GetModelByID(modelID);
        }
        public int UpdateModel(Model model)
        {
            return dal.UpdateModel(model);
        }
        public int InsertCar(Car car)
        {
            return dal.InsertCar(car);
        }
        public DataTable GetCar()
        {
            return dal.GetCar();
        }
        public int UpdateCar(Car car)
        {
            return dal.UpdateCar(car);
        }
        public DataTable GetCarByID(int carID)
        {
            return dal.GetCarByID(carID);
        }
    }
}
