using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessLayer
    {
        static string connString = "Data Source = localhost; Initial Catalog = CarManufactureDB; Integrated Security = true";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        public int InsertManufacturer(Manufacturer manufacturer)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertManufacturer";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@ManufacturerDescription", manufacturer.ManufacturerDescription);
            dbCmd.Parameters.AddWithValue("@ManufacturerLocation", manufacturer.ManufacturerLocation);
            dbCmd.Parameters.AddWithValue("@ContactPerson", manufacturer.ContactPerson);

            int x = dbCmd.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }

        public DataTable GetManufacturer()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_GetManufacturer";
            dbCmd = new SqlCommand(sql, dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateManufacture(Manufacturer manufacturer)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_UpdateManufacture", dbConn);

            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@ManufacturerLocation", manufacturer.ManufacturerLocation);
            dbCmd.Parameters.AddWithValue("@ContactPerson", manufacturer.ContactPerson);
            dbCmd.Parameters.AddWithValue("@ManufacturerID", manufacturer.ManufacturerID);

            int x = dbCmd.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetManufactureByID(int manufacturerID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_GetManufactureByID", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@ManufacturerID", manufacturerID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int InsertModel(Model model)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertModel";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@ManufacturerID", model.ManufacturerID);
            dbCmd.Parameters.AddWithValue("@ManufacturerDescription", model.ManufacturerDescription);
            dbCmd.Parameters.AddWithValue("@ModelDescription", model.ModelDescription);

            int x = dbCmd.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetModel()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_GetModel";
            dbCmd = new SqlCommand(sql, dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateModel(Model model)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_UpdateModel", dbConn);

            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@ManufacturerDescription", model.ManufacturerDescription);
            dbCmd.Parameters.AddWithValue("@ModelID", model.ModelID);

            int x = dbCmd.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetModelByID(int modelID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_GetModelByID", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@ModelID", modelID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int InsertCar(Car car)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertCar";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@ManufacturerDescription", car.ManufacturerDescription);
            dbCmd.Parameters.AddWithValue("@ModelDescription", car.ModelDescription);
            dbCmd.Parameters.AddWithValue("@CarDescription", car.CarDescription);
            dbCmd.Parameters.AddWithValue("@ReleaseYear", car.ReleaseYear);
            dbCmd.Parameters.AddWithValue("@Price", car.Price);

            int x = dbCmd.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetCar()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_GetCar";
            dbCmd = new SqlCommand(sql, dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateCar(Car car)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_UpdateCar", dbConn);

            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@ReleaseYear", car.ReleaseYear);
            dbCmd.Parameters.AddWithValue("@Price", car.Price);
            dbCmd.Parameters.AddWithValue("@CarID", car.CarID);

            int x = dbCmd.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetCarByID(int carID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_GetCarByID", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@CarID", carID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
    }
}
