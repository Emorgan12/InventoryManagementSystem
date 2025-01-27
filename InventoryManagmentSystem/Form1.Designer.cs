namespace InventoryManagmentSystem
{
    partial class InventoryManagment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            InventoryGridView = new DataGridView();
            pTextBox = new TextBox();
            newButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            nTextBox = new TextBox();
            sTextBox = new TextBox();
            qTextBox = new TextBox();
            dTextBox = new TextBox();
            cComboBox = new ComboBox();
            sLabel = new Label();
            dLabel = new Label();
            pLabel = new Label();
            qLabel = new Label();
            cLabel = new Label();
            nLabel = new Label();
            CSVbutton = new Button();
            sellButton = new Button();
            buyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top;
            titleLabel.Font = new Font("Constantia", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(189, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(875, 45);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Inventory Management System";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // InventoryGridView
            // 
            InventoryGridView.Anchor = AnchorStyles.Bottom;
            InventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InventoryGridView.BackgroundColor = Color.White;
            InventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryGridView.GridColor = Color.White;
            InventoryGridView.Location = new Point(18, 261);
            InventoryGridView.Margin = new Padding(3, 2, 3, 2);
            InventoryGridView.Name = "InventoryGridView";
            InventoryGridView.RowHeadersWidth = 51;
            InventoryGridView.Size = new Size(1219, 340);
            InventoryGridView.TabIndex = 1;
            InventoryGridView.CellContentDoubleClick += InventoryGridView_CellContentDoubleClick;
            // 
            // pTextBox
            // 
            pTextBox.Anchor = AnchorStyles.Top;
            pTextBox.Location = new Point(198, 133);
            pTextBox.Margin = new Padding(3, 2, 3, 2);
            pTextBox.Name = "pTextBox";
            pTextBox.Size = new Size(276, 23);
            pTextBox.TabIndex = 2;
            // 
            // newButton
            // 
            newButton.Anchor = AnchorStyles.Top;
            newButton.Font = new Font("Constantia", 12F);
            newButton.Location = new Point(198, 158);
            newButton.Margin = new Padding(3, 2, 3, 2);
            newButton.Name = "newButton";
            newButton.Size = new Size(276, 35);
            newButton.TabIndex = 3;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top;
            deleteButton.Font = new Font("Constantia", 12F);
            deleteButton.Location = new Point(760, 158);
            deleteButton.Margin = new Padding(3, 2, 3, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(277, 35);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top;
            saveButton.Font = new Font("Constantia", 12F);
            saveButton.Location = new Point(477, 158);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(276, 35);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // nTextBox
            // 
            nTextBox.Anchor = AnchorStyles.Top;
            nTextBox.Location = new Point(478, 89);
            nTextBox.Margin = new Padding(3, 2, 3, 2);
            nTextBox.Name = "nTextBox";
            nTextBox.Size = new Size(276, 23);
            nTextBox.TabIndex = 6;
            // 
            // sTextBox
            // 
            sTextBox.Anchor = AnchorStyles.Top;
            sTextBox.Location = new Point(198, 89);
            sTextBox.Margin = new Padding(3, 2, 3, 2);
            sTextBox.Name = "sTextBox";
            sTextBox.Size = new Size(276, 23);
            sTextBox.TabIndex = 8;
            // 
            // qTextBox
            // 
            qTextBox.Anchor = AnchorStyles.Top;
            qTextBox.Location = new Point(761, 133);
            qTextBox.Margin = new Padding(3, 2, 3, 2);
            qTextBox.Name = "qTextBox";
            qTextBox.Size = new Size(276, 23);
            qTextBox.TabIndex = 9;
            // 
            // dTextBox
            // 
            dTextBox.Anchor = AnchorStyles.Top;
            dTextBox.Location = new Point(478, 133);
            dTextBox.Margin = new Padding(3, 2, 3, 2);
            dTextBox.Name = "dTextBox";
            dTextBox.Size = new Size(275, 23);
            dTextBox.TabIndex = 10;
            // 
            // cComboBox
            // 
            cComboBox.Anchor = AnchorStyles.Top;
            cComboBox.FormattingEnabled = true;
            cComboBox.Items.AddRange(new object[] { "Automotive", "Hardware", "Groceries", "Health", "Toys" });
            cComboBox.Location = new Point(761, 89);
            cComboBox.Margin = new Padding(3, 2, 3, 2);
            cComboBox.Name = "cComboBox";
            cComboBox.Size = new Size(275, 23);
            cComboBox.TabIndex = 11;
            // 
            // sLabel
            // 
            sLabel.Anchor = AnchorStyles.Top;
            sLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            sLabel.ForeColor = Color.WhiteSmoke;
            sLabel.Location = new Point(198, 68);
            sLabel.Name = "sLabel";
            sLabel.Size = new Size(275, 19);
            sLabel.TabIndex = 12;
            sLabel.Text = "SKU:";
            // 
            // dLabel
            // 
            dLabel.Anchor = AnchorStyles.Top;
            dLabel.BackColor = Color.Transparent;
            dLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            dLabel.ForeColor = Color.WhiteSmoke;
            dLabel.Location = new Point(478, 112);
            dLabel.Name = "dLabel";
            dLabel.Size = new Size(276, 19);
            dLabel.TabIndex = 13;
            dLabel.Text = "Description";
            // 
            // pLabel
            // 
            pLabel.Anchor = AnchorStyles.Top;
            pLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            pLabel.ForeColor = Color.WhiteSmoke;
            pLabel.Location = new Point(198, 112);
            pLabel.Name = "pLabel";
            pLabel.Size = new Size(276, 19);
            pLabel.TabIndex = 14;
            pLabel.Text = "Price:";
            // 
            // qLabel
            // 
            qLabel.Anchor = AnchorStyles.Top;
            qLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            qLabel.ForeColor = Color.WhiteSmoke;
            qLabel.Location = new Point(761, 112);
            qLabel.Name = "qLabel";
            qLabel.Size = new Size(276, 19);
            qLabel.TabIndex = 15;
            qLabel.Text = "Quantity";
            // 
            // cLabel
            // 
            cLabel.Anchor = AnchorStyles.Top;
            cLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            cLabel.ForeColor = Color.WhiteSmoke;
            cLabel.Location = new Point(761, 68);
            cLabel.Name = "cLabel";
            cLabel.Size = new Size(276, 19);
            cLabel.TabIndex = 16;
            cLabel.Text = "Category:";
            // 
            // nLabel
            // 
            nLabel.Anchor = AnchorStyles.Top;
            nLabel.BackColor = Color.Transparent;
            nLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            nLabel.ForeColor = Color.WhiteSmoke;
            nLabel.Location = new Point(478, 67);
            nLabel.Name = "nLabel";
            nLabel.Size = new Size(275, 20);
            nLabel.TabIndex = 17;
            nLabel.Text = "Name:";
            // 
            // CSVbutton
            // 
            CSVbutton.Anchor = AnchorStyles.Top;
            CSVbutton.Font = new Font("Constantia", 12F);
            CSVbutton.Location = new Point(479, 204);
            CSVbutton.Margin = new Padding(3, 2, 3, 2);
            CSVbutton.Name = "CSVbutton";
            CSVbutton.Size = new Size(276, 35);
            CSVbutton.TabIndex = 18;
            CSVbutton.Text = "Export to CSV";
            CSVbutton.UseVisualStyleBackColor = true;
            CSVbutton.Click += CSVbutton_Click;
            // 
            // sellButton
            // 
            sellButton.Anchor = AnchorStyles.Top;
            sellButton.Font = new Font("Constantia", 12F);
            sellButton.Location = new Point(198, 204);
            sellButton.Margin = new Padding(3, 2, 3, 2);
            sellButton.Name = "sellButton";
            sellButton.Size = new Size(276, 35);
            sellButton.TabIndex = 19;
            sellButton.Text = "Sell";
            sellButton.UseVisualStyleBackColor = true;
            sellButton.Click += sellButton_Click;
            // 
            // buyButton
            // 
            buyButton.Anchor = AnchorStyles.Top;
            buyButton.Font = new Font("Constantia", 12F);
            buyButton.Location = new Point(760, 204);
            buyButton.Margin = new Padding(3, 2, 3, 2);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(276, 35);
            buyButton.TabIndex = 20;
            buyButton.Text = "Buy";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // InventoryManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 144, 196);
            ClientSize = new Size(1240, 603);
            Controls.Add(buyButton);
            Controls.Add(sellButton);
            Controls.Add(CSVbutton);
            Controls.Add(nLabel);
            Controls.Add(cLabel);
            Controls.Add(qLabel);
            Controls.Add(pLabel);
            Controls.Add(dLabel);
            Controls.Add(sLabel);
            Controls.Add(cComboBox);
            Controls.Add(dTextBox);
            Controls.Add(qTextBox);
            Controls.Add(sTextBox);
            Controls.Add(nTextBox);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(newButton);
            Controls.Add(pTextBox);
            Controls.Add(InventoryGridView);
            Controls.Add(titleLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InventoryManagment";
            Text = "Inventory Managment";
            Load += InventoryManagment_Load;
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private DataGridView InventoryGridView;
        private TextBox pTextBox;
        private Button newButton;
        private Button deleteButton;
        private Button saveButton;
        private TextBox nTextBox;
        private TextBox sTextBox;
        private TextBox qTextBox;
        private TextBox dTextBox;
        private ComboBox cComboBox;
        private Label sLabel;
        private Label dLabel;
        private Label pLabel;
        private Label qLabel;
        private Label cLabel;
        private Label nLabel;
        private Button CSVbutton;
        private Button sellButton;
        private Button buyButton;
    }
}
