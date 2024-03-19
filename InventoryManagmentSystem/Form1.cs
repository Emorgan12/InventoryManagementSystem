using System.Data;

namespace InventoryManagmentSystem
{
    public partial class InventoryManagment : Form
    {
        DataTable inventory = new DataTable();
        public InventoryManagment()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            sTextBox.Text = "";
            nTextBox.Text = "";
            pTextBox.Text = "";
            qTextBox.Text = "";
            dTextBox.Text = "";
            cComboBox.SelectedIndex = -1;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string sku = sTextBox.Text;
            string name = nTextBox.Text;
            string price = pTextBox.Text;
            string quantity = qTextBox.Text;
            string description = dTextBox.Text;
            string category = (string)cComboBox.SelectedItem;

            inventory.Rows.Add(sku, name, category, price, description, quantity);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void InventoryGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InventoryManagment_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Quantity");

            InventoryGridView.DataSource = inventory;
        }
    }
}
