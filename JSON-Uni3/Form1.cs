using System.Text.Json;
using System.Xml;

namespace JSON_Uni3
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();
        
        public Form1()
        {
            InitializeComponent();
            dgvProducts.DataSource = products;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtId.Text, out int id) && !string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtCategory.Text) && decimal.TryParse(txtPrice.Text, out decimal price))
            {
                if (products.Any(p => p.Id == id))
                {
                    MessageBox.Show("The ID already exists. Enter a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                products.Add(new Product { Id = id, Name = txtName.Text, Category = txtCategory.Text, Price = price });
                UpdateGrid();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Enter valid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int selectedId = (int)dgvProducts.SelectedRows[0].Cells["Id"].Value;
                products.RemoveAll(p => p.Id == selectedId);
                UpdateGrid();
            }
            else
            {
                MessageBox.Show("Select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos JSON (*.json)|*.json";
                openFileDialog.Title = "Load data from JSON";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string json = File.ReadAllText(openFileDialog.FileName);
                    products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
                    UpdateGrid();
                    MessageBox.Show("Data loaded successfully.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int searchId))
            {
                dgvProducts.DataSource = products.Where(p => p.Id == searchId).ToList();
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos JSON (*.json)|*.json";
                saveFileDialog.Title = "Save data as JSON";
                saveFileDialog.FileName = "products.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(saveFileDialog.FileName, json);
                    MessageBox.Show($"Data saved in {saveFileDialog.FileName}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ClearInputs()
        {
            txtName.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }
        private void UpdateGrid()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }
    }
}
