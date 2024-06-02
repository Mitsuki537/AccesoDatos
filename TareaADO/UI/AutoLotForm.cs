using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.UI
{
    public partial class AutoLotForm : Form
    {
        public AutoLotForm()
        {
            InitializeComponent();
        }

        private void btnMakesForm_Click(object sender, EventArgs e)
        {
            MakesForm frm = new MakesForm();
            frm.Show();
        }

        private void btnInventoryForm_Click(object sender, EventArgs e)
        {
            InventoryForm frm = new InventoryForm();
            frm.Show();
        }
    }
}
