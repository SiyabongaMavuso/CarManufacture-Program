using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace Practical_3
{
    public partial class FrmCars : Form
    {
        public FrmCars()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void FrmCars_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Refresh()
        {
            dgvCars.DataSource = bll.GetCar();

            cmbManufacturer.DataSource = bll.GetManufacturer();
            cmbManufacturer.ValueMember = "ManufacturerID";
            cmbManufacturer.DisplayMember = "ManufacturerDescription";

            cmbModel.DataSource = bll.GetModel();
            cmbModel.ValueMember = "ModelID";
            cmbModel.DisplayMember = "ModelDescription";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.ManufacturerDescription = cmbManufacturer.SelectedValue.ToString();
            car.ModelDescription = cmbModel.SelectedValue.ToString();
            car.CarDescription = txtCarDescription.Text;
            car.ReleaseYear = txtYear.Text;
            car.Price = double.Parse(txtPrice.Text);

            int x = bll.InsertCar(car);
            if (x > 0)
            {
                MessageBox.Show(x + " Added");
                Refresh();
            }
            else
            {
                MessageBox.Show(x + " Added");
                Refresh();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.ReleaseYear = txtYear.Text;
            car.Price = double.Parse(txtPrice.Text);
            car.CarID = int.Parse(dgvCars.SelectedRows[0].Cells["CarID"].Value.ToString());

            int x = bll.UpdateCar(car);
            if (x > 0)
            {
                MessageBox.Show(x + " Updated.");
                Refresh();
            }
            else
            {
                MessageBox.Show(x + " Updated.");
                Refresh();
            }
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var n = new FrmMenu();
            n.Show();
            this.Hide();
        }

        private void DgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = bll.GetCarByID(int.Parse(dgvCars.SelectedRows[0].Cells["CarID"].Value.ToString()));
                cmbManufacturer.Text = dt.Rows[0]["ManufactureDescription"].ToString();
                cmbModel.Text = dt.Rows[0]["ModelDescription"].ToString();
                txtCarDescription.Text = dt.Rows[0]["CarDescription"].ToString();
                txtCarDescription.Enabled = false;
                cmbManufacturer.Enabled = false;
                cmbModel.Enabled = false;
            }
        }
    }
}
