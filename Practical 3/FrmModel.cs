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
    public partial class FrmModel : Form
    {
        public FrmModel()
        {
            InitializeComponent();
        }

        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void FrmModel_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Refresh()
        {
            dgvModel.DataSource = bll.GetModel();

            cmbManufacturer.DataSource = bll.GetManufacturer();
            cmbManufacturer.ValueMember = "ManufacturerID";
            cmbManufacturer.DisplayMember = "ManufacturerDescription";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.ModelDescription = txtModelDescription.Text;
            model.ManufacturerDescription = cmbManufacturer.SelectedValue.ToString();
            model.ManufacturerID = int.Parse(cmbManufacturer.SelectedValue.ToString());
            
            int x = bll.InsertModel(model);
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
            Model model = new Model();
            model.ManufacturerID = int.Parse(cmbManufacturer.SelectedItem.ToString());
            model.ModelID = int.Parse(dgvModel.SelectedRows[0].Cells["ManufacturerID"].Value.ToString());

            int x = bll.UpdateModel(model);
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

        private void DgvModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModel.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = bll.GetModelByID(int.Parse(dgvModel.SelectedRows[0].Cells["ModelID"].Value.ToString()));
                txtModelDescription.Text = dt.Rows[0]["ModelDescription"].ToString();
                cmbManufacturer.Text = dt.Rows[0]["ManufacturerID"].ToString();
                txtModelDescription.Enabled = false;

            }
        }
    }
}
