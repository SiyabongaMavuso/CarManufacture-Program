using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_3
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnCar_Click(object sender, EventArgs e)
        {
            var n = new FrmCars();
            n.Show();
            this.Hide();
        }

        private void BtnModel_Click(object sender, EventArgs e)
        {
            var n = new FrmModel();
            n.Show();
            this.Hide();
        }

        private void BtnManu_Click(object sender, EventArgs e)
        {
            var n = new FrmManufacture();
            n.Show();
            this.Hide();
        }
    }
}
