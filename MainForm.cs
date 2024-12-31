using InventoryShipmentManagement.Logging;
using InventoryShipmentManagement.Models;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryShipmentManagement
{
    public partial class MainForm : Form
    {
        private readonly ApiClient _apiClient;
        public MainForm()
        {
            InitializeComponent();
            _apiClient = new ApiClient("https://localhost:5001/");
            LoadData();
        }

        private async void LoadData()
        {
            var items = await _apiClient.GetInventoryItemsAsync();
            dataGridInventory.DataSource = items;
            Logger.Log("Data loaded/Refreshed");
        }

        private void dataGridInventory_SelectionChanged(object sender, EventArgs e)
        {
            dataGridInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridInventory.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridInventory.SelectedRows[0];

                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableTextBox();
            ClearTextBox();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (dataGridInventory.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridInventory.SelectedRows[0];
                    var updatedItem = new InventoryItem
                    {
                        Id = (int)selectedRow.Cells["Id"].Value,
                        Name = txtName.Text,
                        Quantity = int.Parse(txtQuantity.Text),
                        Price = decimal.Parse(txtPrice.Text)
                    };
                    await _apiClient.UpdateInventoryItemAsync(updatedItem);
                    LoadData(); // Refresh the data grid to show updated data
                }
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                btnSave.Visible = true;
                DisableTextBox();
                MessageBox.Show("Data Updated successfully!");
                btnUpdate.Enabled = false;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var newItem = new InventoryItem
                {
                    Name = txtName.Text,
                    Quantity = int.Parse(txtQuantity.Text),
                    Price = decimal.Parse(txtPrice.Text),
                    ShipmentDate = DateTime.Now
                };
                await _apiClient.AddInventoryItemAsync(newItem);
                DisableTextBox();
                LoadData();
                ClearTextBox();
                btnAdd.Visible = true;
                MessageBox.Show("Data saved successfully!");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridInventory.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridInventory.SelectedRows[0];
                var id = (int)selectedRow.Cells["Id"].Value;
                var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    await _apiClient.DeleteInventoryItemAsync(id);
                    LoadData(); // Refresh the data grid to show updated data
                }
            }
        }

        private bool ValidateInputs()
        {
            Logger.Log("Validating the provided Inputs");
            // Check if all fields are not empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is a required field.");
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Quantity is a required field.");
                txtQuantity.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price is a required field.");
                txtPrice.Focus(); return false;
            }
            // Check if Quantity and Price contain only integer values
            if (!int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer for Quantity.");
                txtQuantity.Focus();
                return false;
            }
            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer for Price.");
                txtPrice.Focus();
                return false;
            }
            return true;
        }


        private void EnableTextBox()
        {
            txtName.Enabled = true;
            txtQuantity.Enabled = true;
            txtPrice.Enabled = true;
        }

        private void DisableTextBox()
        {
            txtName.Enabled = false;
            txtQuantity.Enabled = false;
            txtPrice.Enabled = false;
        }

        private void ClearTextBox()
        {
            txtName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableTextBox();
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnUpdate.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;

            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            ClearTextBox();
            DisableTextBox();
            LoadData();
        }



        private async void btnExportToExcel_Click(object sender, EventArgs e)
        {
            List<InventoryItem> inventoryItems = await _apiClient.GetExportInventoryItemsAsync();

            //Creating an Instance of the Generic Exporter
            var exporter = new ExcelExporter<InventoryItem>();

            string filePath = "A:\\Inventory Shipment Management\\InventoryShipmentManagementV2\\ExportData\\InventoryItems.xlsx";

            //Export the data
            exporter.ExportToExcel(inventoryItems, filePath);

            Logger.Log("Data Exported to: " + filePath);
        }      
    }
}
