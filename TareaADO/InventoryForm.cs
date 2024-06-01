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
using System.Xml.Linq;

namespace TareaADO
{
    public partial class InventoryForm : Form
    {
        private readonly PetRepository _petRepository;
        private readonly MakeRepository _makeRepository;

        public InventoryForm()
        {
            InitializeComponent();
            string connection = ConfigurationManager.ConnectionStrings["con_str"].ConnectionString;
            _petRepository = new PetRepository(connection);
            _makeRepository = new MakeRepository(connection);
            RefreshData();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            cmbMakes.DataSource = _makeRepository.GetAll()
                .Select(m => m.Id)
                .ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var pet = (Pet)dgvInventory.SelectedRows[0].DataBoundItem;

            if (String.IsNullOrEmpty(txtPetName.Text) && String.IsNullOrEmpty(txtColor.Text))
            {
                MessageBox.Show("You must provide at least a new name or color" + Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pet.Color = txtColor.Text;
            pet.PetName = txtPetName.Text;
            pet.MakeId = (int)cmbMakes.SelectedValue;
            _petRepository.Update(pet);
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                dgvInventory.DataSource = _petRepository.GetAll();
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
                    _petRepository.Delete((int)id);
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
            if (dgvInventory.SelectedRows.Count > 0 && dgvInventory.SelectedRows[0].Cells[0].Value != null)
            {
                return Convert.ToInt32(dgvInventory.SelectedRows[0].Cells[0].Value);
            }

            return null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtPetName.Text) || String.IsNullOrEmpty(txtColor.Text))
            {
                MessageBox.Show("You must provide a name and color" + Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pet pet = new Pet
            {
                PetName = txtPetName.Text,
                MakeId = (int)cmbMakes.SelectedValue,
                Color = txtColor.Text
            };

            _petRepository.Insert(pet);
            RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtSearch.Text))
            {
                RefreshData();
                return;
            }

            int id = Convert.ToInt32(txtSearch.Text);

            var pets = new List<Pet>();
            var pet = _petRepository.GetById(id);

            if(pet == null)
            {
                MessageBox.Show("Pet not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pets.Add(pet);

            dgvInventory.DataSource = pets;
        }
    }
}
