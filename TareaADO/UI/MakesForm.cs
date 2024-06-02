using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO.Models;

namespace ADO.UI
{
    public partial class MakesForm : Form
    {
        private readonly MakeRepository _makeRepository;

        public MakesForm()
        {
            InitializeComponent();
            string connection = ConfigurationManager.ConnectionStrings["con_str"].ConnectionString;
            _makeRepository = new MakeRepository(connection);  
            RefreshData();
        }
     

        private void dgvMakes_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvMakes.CurrentRow != null)
            {
                var make = (Make)dgvMakes.CurrentRow.DataBoundItem;
                txtName.Text = make.Id.ToString();
            }
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var make = (Make)dgvMakes.SelectedRows[0].DataBoundItem;

            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("You must provide a name" + Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            make.Name = txtName.Text;
            _makeRepository.Update(make);
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                dgvMakes.DataSource = _makeRepository.GetAll();
            }
            catch (Exception ex)
            {
                ShowError("Failed to retrieve data", ex);
            }
        }

        private void ShowError(string msg, Exception e)
        {
            MessageBox.Show(msg + Environment.NewLine + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();

            try
            {
                if (id != null)
                {
                    _makeRepository.Delete((int)id);
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                ShowError("Error when deleting record", ex);
            }
        }

        private int? GetSelectedId()
        {
            if (dgvMakes.SelectedRows.Count > 0 && dgvMakes.SelectedRows[0].Cells[0].Value != null)
            {
                return Convert.ToInt32(dgvMakes.SelectedRows[0].Cells[0].Value);
            }

            return null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("You must provide a name" + Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Make make = new Make
            {
                Name = txtName.Text
            };

            _makeRepository.Insert(make);
            RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                RefreshData();
                return;
            }

            int id = Convert.ToInt32(txtSearch.Text);

            var makes = new List<Make>();
            var make = _makeRepository.GetById(id);

            if (make == null)
            {
                MessageBox.Show("Make not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            makes.Add(make);

            dgvMakes.DataSource = makes;
        }
    }
}
