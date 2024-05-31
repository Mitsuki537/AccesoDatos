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
    public partial class CustomerForm : Form
    {
        private readonly AutoLotContext _context = new AutoLotContext();

        public CustomerForm()
        {
            InitializeComponent();
            dgvCustomers.DataError += dgvCustomers_DataError;
            LoadCustomersAsync();
        }

        private void dgvCustomers_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private async void LoadCustomersAsync()
        {
            try
            {
                dgvCustomers.SelectionChanged -= dgvCustomer_SelectionChanged;  // Deshabilita el evento
                var customers = await Task.Run(() => _context.Customers.ToList());
                dgvCustomers.DataSource = customers;
                dgvCustomers.Columns["CreditRisks"].Visible = false;
                dgvCustomers.SelectionChanged += dgvCustomer_SelectionChanged;
                ClearCustomerInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}");
            }
        }

        private void ClearCustomerInputs()
        {
            txtCustomerId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpTimeStamp.Value = DateTime.Now;
        }

        private void dgvCustomer_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                var customer = (Customer)dgvCustomers.CurrentRow.DataBoundItem;
                txtCustomerId.Text = customer.Id.ToString();
                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                if (customer.TimeStamp != null && customer.TimeStamp.Length == 8)
                {
                    long ticks = BitConverter.ToInt64(customer.TimeStamp, 0);
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
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new Customer
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    TimeStamp = BitConverter.GetBytes(dtpTimeStamp.Value.Ticks)
                };
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                LoadCustomersAsync();
                ClearCustomerInputs();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error adding customer: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding customer: {ex.Message}");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(txtCustomerId.Text);
                var customer = await _context.Customers.FindAsync(customerId);
                if (customer != null)
                {
                    customer.FirstName = txtFirstName.Text;
                    customer.LastName = txtLastName.Text;
                    customer.TimeStamp = BitConverter.GetBytes(dtpTimeStamp.Value.Ticks);
                    // _context.Entry(customer).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    LoadCustomersAsync();
                    ClearCustomerInputs();
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error updating customer: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(txtCustomerId.Text);
                var customer = await _context.Customers.FindAsync(customerId);
                if (customer != null)
                {
                    _context.Customers.Remove(customer);
                    await _context.SaveChangesAsync();
                    LoadCustomersAsync();
                    ClearCustomerInputs();
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}");
            }
        }
    }
}
