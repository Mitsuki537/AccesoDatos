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
    public partial class CustomerForm : Form
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerForm()
        {
            InitializeComponent();
            var _context = new AutoLotContext();
            _customerRepository = new Repository<Customer>(_context);
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
                dgvCustomers.SelectionChanged -= dgvCustomer_SelectionChanged;
                var customers = await _customerRepository.GetAllAsync();
                dgvCustomers.DataSource = customers;
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
        }

        private void dgvCustomer_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                var customer = (Customer)dgvCustomers.CurrentRow.DataBoundItem;
                txtCustomerId.Text = customer.Id.ToString();
                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
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
                };
                await _customerRepository.AddAsync(customer);
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
                var customer = await _customerRepository.GetByIdAsync(customerId);
                if (customer != null)
                {
                    customer.FirstName = txtFirstName.Text;
                    customer.LastName = txtLastName.Text;
                    await _customerRepository.UpdateAsync(customer);
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
                await _customerRepository.DeleteAsync(customerId);
                LoadCustomersAsync();
                ClearCustomerInputs();
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
                if (int.TryParse(txtSearchCustomerId.Text, out int id))
                {
                    var customer = await _customerRepository.GetByIdAsync(id);
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

        private void SelectCustomerById(int id)
        {
            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                if (row.DataBoundItem is Customer customer && customer.Id == id)
                {
                    row.Selected = true;
                    dgvCustomers.CurrentCell = row.Cells[0];  
                    FillCustomerDetails(customer);
                    return;
                }
            }
        }

        private void FillCustomerDetails(Customer customer)
        {
            txtCustomerId.Text = customer.Id.ToString();
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
        }
    }
}
