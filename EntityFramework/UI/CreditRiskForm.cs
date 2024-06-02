using EntityFramework.Data;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework.UI
{
    public partial class CreditRiskForm : Form
    {
        private readonly IRepository<CreditRisk> _creditRiskRepository;
        public CreditRiskForm()
        {
            InitializeComponent();
            var _context = new AutoLotContext();
            _creditRiskRepository = new Repository<CreditRisk>(_context);
            dgvCreditRisks.DataError += dgvCreditRisks_DataError;
            dgvCreditRisks.SelectionChanged += dgvCreditRisks_SelectionChanged;
            cboCustomers.SelectedIndexChanged += cboCustomers_SelectedIndexChanged;
            LoadCustomersAsync();
            LoadCreditRisksAsync();
            ClearCreditRiskInputs();
        }

        private async void LoadCustomersAsync()
        {
            try
            {
                using (var context = new AutoLotContext())
                {
                    var customers = await Task.Run(() => context.Customers.ToList());
                    cboCustomers.DataSource = customers;
                    cboCustomers.DisplayMember = "FirstName";
                    cboCustomers.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}");
            }
        }

        private async void LoadCreditRisksAsync()
        {
            try
            {
                var creditRisks = await _creditRiskRepository.GetAllAsync();
                dgvCreditRisks.DataSource = creditRisks;
                dgvCreditRisks.Columns["Customer"].Visible = false;
                dgvCreditRisks.ClearSelection();
                ClearCreditRiskInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading credit risks: {ex.Message}");
            }
        }

        private void cboCustomers_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboCustomers.SelectedItem is Customer selectedCustomer)
            {
                txtCustomerId.Text = selectedCustomer.Id.ToString();
                txtFirstName.Text = selectedCustomer.FirstName;
                txtLastName.Text = selectedCustomer.LastName;
            }
            else
            {
                ClearCreditRiskInputs();
            }
        }
        private void dgvCreditRisks_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCreditRisks.CurrentRow != null && dgvCreditRisks.CurrentRow.DataBoundItem is CreditRisk creditRisk)
            {
                txtCustomerId.Text = creditRisk.Id.ToString();
                txtFirstName.Text = creditRisk.FirstName;
                txtLastName.Text = creditRisk.LastName;
            }
            else
            {
                ClearCreditRiskInputs();
            }
        }

        private void ClearCreditRiskInputs()
        {
            txtCustomerId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
        }

        private void dgvCreditRisks_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var creditRisk = new CreditRisk
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    CustomerId = (int)cboCustomers.SelectedValue,
                };
                await _creditRiskRepository.AddAsync(creditRisk);
                LoadCreditRisksAsync();
                ClearCreditRiskInputs();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error adding credit risk: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding credit risk: {ex.Message}");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerId.Text) || !int.TryParse(txtCustomerId.Text, out int creditRiskId))
                {
                    MessageBox.Show("Please enter a valid credit risk Id.");
                    return;
                }

                var creditRisk = await _creditRiskRepository.GetByIdAsync(creditRiskId);
                if (creditRisk == null)
                {
                    MessageBox.Show("Credit risk not found.");
                    return;
                }

                if (cboCustomers.SelectedValue == null || !(cboCustomers.SelectedValue is int))
                {
                    MessageBox.Show("Please select a valid customer.");
                    return;
                }

                creditRisk.FirstName = txtFirstName.Text;
                creditRisk.LastName = txtLastName.Text;
                creditRisk.CustomerId = (int)cboCustomers.SelectedValue;

                await _creditRiskRepository.UpdateAsync(creditRisk);
                LoadCreditRisksAsync();
                ClearCreditRiskInputs();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error updating credit risk: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating credit risk: {ex.Message}");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int creditRiskId = int.Parse(txtCustomerId.Text);
                await _creditRiskRepository.DeleteAsync(creditRiskId);
                LoadCreditRisksAsync();
                ClearCreditRiskInputs();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error deleting credit risk: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting credit risk: {ex.Message}");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchCreditRiskId.Text, out int id))
            {
                var customer = await _creditRiskRepository.GetByIdAsync(id);
                if (customer != null)
                {
                    SelectCustomerById(id);
                    FillCustomerDetails(customer);
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer Id.");
            }
        }

        private void FillCustomerDetails(CreditRisk customer)
        {
            txtCustomerId.Text = customer.Id.ToString();
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
        }

        private void SelectCustomerById(int id)
        {
            foreach (DataGridViewRow row in dgvCreditRisks.Rows)
            {
                if (row.DataBoundItem is CreditRisk creditRisk && creditRisk.Id == id)
                {
                    row.Selected = true;
                    dgvCreditRisks.CurrentCell = row.Cells[0];
                    FillCustomerDetails(creditRisk);
                    return;
                }
            }
        }
    }
}
