using System.Data;
using System.Text;


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
            string sku = "";
            string name = "";
            string price = "";
            string quantity = "";
            string description = "";
            string category = (string)cComboBox.SelectedItem;
            bool sInt = false;
            bool pInt = false;
            bool qInt = false;
            if (int.TryParse(sTextBox.Text, out int ignoreMe))
            {
                sku = sTextBox.Text;
                sInt = true;
            }
            else
                sTextBox.Text = "Must be integer";

            if (float.TryParse(pTextBox.Text, out float ignoreThis))
            {
                price = pTextBox.Text;
                pInt = true;
            }
            else
                pTextBox.Text = "Must be Numerical";

            if (int.TryParse(qTextBox.Text, out ignoreMe))
            {
                quantity = qTextBox.Text;
                qInt = true;
            }
            else
                qTextBox.Text = "Must be integer";
            if (pInt && sInt && qInt)
            {
                name = nTextBox.Text;
                description = dTextBox.Text;
                inventory.Rows.Add(sku, name, category, price, description, quantity);
                newButton_Click(sender, e);
            }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[InventoryGridView.CurrentCell.RowIndex].Delete();
            }

            catch (Exception err)
            {
                Console.WriteLine("Error " + err);
            }
        }

        private void InventoryGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ;
                sTextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                pTextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                qTextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                nTextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                dTextBox.Text = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();

                string itemToLookFor = inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                cComboBox.SelectedIndex = cComboBox.Items.IndexOf(itemToLookFor);
            }
            catch (Exception err)
            {
                Console.WriteLine("There has been an error: " + err);
            }
        }

        private void InventoryManagment_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Quantity");
            inventory.Columns.Add("Sold");

            InventoryGridView.DataSource = inventory;
            PerformAutoScale();

        }

        private void CSVbutton_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            string[] columnNames = inventory.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
            string[] file = File.ReadAllLines("test.csv");
            if (file.Length == 1) 
                sb.AppendLine(string.Join(",", columnNames));
            foreach (DataRow row in inventory.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();
                sb.AppendLine(string.Join(",", fields));

                File.AppendAllText("test.csv", sb.ToString());
                newButton_Click(sender, e);
            }
            
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            int soldValue = 0;
            int quantityValue = 0;
            if (inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[6].ToString() != string.Empty)
            {
                soldValue = int.Parse(inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[6].ToString());
                inventory.Rows[InventoryGridView.CurrentCell.RowIndex]["Sold"] = soldValue + 1;
            }
            else
                inventory.Rows[InventoryGridView.CurrentCell.RowIndex]["Sold"] = 1;

            quantityValue = int.Parse(inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString());
            inventory.Rows[InventoryGridView.CurrentCell.RowIndex]["Quantity"] = quantityValue - 1;

        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            int quantityValue = int.Parse(inventory.Rows[InventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString());
            inventory.Rows[InventoryGridView.CurrentCell.RowIndex]["Quantity"] = quantityValue + 1;
        }


    }
}
