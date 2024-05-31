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

namespace EntityFramework.WindForms
{
    public partial class CreditRiskForm : Form
    {
        private readonly AutoLotContext _context = new AutoLotContext();

        public CreditRiskForm()
        {
            InitializeComponent();
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
                var creditRisks = await Task.Run(() => _context.CreditRisks.Include(cr => cr.Customer).ToList());
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
            if (dgvCreditRisks.CurrentRow != null && dgvCreditRisks.CurrentRow.DataBoundItem is CreditRisk creditRisk)
            {
                txtCustomerId.Text = creditRisk.Id.ToString();
                txtFirstName.Text = creditRisk.FirstName;
                txtLastName.Text = creditRisk.LastName;

                if (creditRisk.TimeStamp != null && creditRisk.TimeStamp.Length == 8)
                {
                    long ticks = BitConverter.ToInt64(creditRisk.TimeStamp, 0);
                    if (ticks >= DateTime.MinValue.Ticks && ticks <= DateTime.MaxValue.Ticks)
                    {
                        dtpTimeStamp.Value = new DateTime(ticks);
                    }
                    else
                    {
                        dtpTimeStamp.Value = DateTime.Now;
                    }
                }
                else
                {
                    dtpTimeStamp.Value = DateTime.Now;
                }
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
                cboCustomers.SelectedValue = creditRisk.CustomerId;

                if (creditRisk.TimeStamp != null && creditRisk.TimeStamp.Length == 8)
                {
                    long ticks = BitConverter.ToInt64(creditRisk.TimeStamp, 0);
                    if (ticks >= DateTime.MinValue.Ticks && ticks <= DateTime.MaxValue.Ticks)
                    {
                        dtpTimeStamp.Value = new DateTime(ticks);
                    }
                    else
                    {
                        dtpTimeStamp.Value = DateTime.Now;
                    }
                }
                else
                {
                    dtpTimeStamp.Value = DateTime.Now;
                }
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
            dtpTimeStamp.Value = DateTime.Now;
            cboCustomers.SelectedIndex = -1;
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
                    TimeStamp = BitConverter.GetBytes(dtpTimeStamp.Value.Ticks)
                };
                _context.CreditRisks.Add(creditRisk);
                await _context.SaveChangesAsync();
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
                    MessageBox.Show("Please enter a valid credit risk ID.");
                    return;
                }

                var creditRisk = await _context.CreditRisks.FindAsync(creditRiskId);
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
                creditRisk.TimeStamp = BitConverter.GetBytes(dtpTimeStamp.Value.Ticks);

                _context.Entry(creditRisk).State = EntityState.Modified;
                await _context.SaveChangesAsync();
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
                var creditRisk = await _context.CreditRisks.FindAsync(creditRiskId);
                if (creditRisk != null)
                {
                    _context.CreditRisks.Remove(creditRisk);
                    await _context.SaveChangesAsync();
                    LoadCreditRisksAsync();
                    ClearCreditRiskInputs();
                }
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
    }
}
