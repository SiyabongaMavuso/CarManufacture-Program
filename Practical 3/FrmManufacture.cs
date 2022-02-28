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
    public partial class FrmManufacture : Form
    {
        public FrmManufacture()
        {
            InitializeComponent();
        }

        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }
        public void Refresh()
        {
            dgvManufacture.DataSource = bll.GetManufacturer();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.ManufacturerDescription = txtManufacturerDescription.Text;
            manufacturer.ManufacturerLocation = txtManufacturerLocation.Text;
            manufacturer.ContactPerson = txtContactPerson.Text;

            int x = bll.InsertManufacturer(manufacturer);
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
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.ManufacturerLocation = txtManufacturerLocation.Text;
            manufacturer.ContactPerson = txtContactPerson.Text;
            manufacturer.ManufacturerID = int.Parse(dgvManufacture.SelectedRows[0].Cells["ManufacturerID"].Value.ToString());

            int x = bll.UpdateManufacture(manufacturer);
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
            //var n = new FrmManu();
            //n.Show();
            //this.Hide();

        }

        private void DgvManufacture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvManufacture.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = bll.GetManufactureByID(int.Parse(dgvManufacture.SelectedRows[0].Cells["ManufacturerID"].Value.ToString()));
                txtManufacturerDescription.Text = dt.Rows[0]["ManufacturerDescription"].ToString();
                txtManufacturerLocation.Text = dt.Rows[0]["ManufacturerLocation"].ToString();
                txtContactPerson.Text = dt.Rows[0]["ContactPerson"].ToString();
                txtManufacturerDescription.Enabled = false;
                
            }
        }
    }
}
