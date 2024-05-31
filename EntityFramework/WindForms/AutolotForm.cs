using EntityFramework.WindForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class AutolotForm : Form
    {
        public AutolotForm()
        {
            InitializeComponent();
        }

        private void AutolotForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerForm_Click(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm();
            frm.Show();
        }

        private void btnCreditRisk_Click(object sender, EventArgs e)
        {
            CreditRiskForm frm = new CreditRiskForm();
            frm.Show();
        }
    }
}
