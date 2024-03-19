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
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Constantia", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1000, 60);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Solutionize Inventory Management System Pro";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // InventoryGridView
            // 
            InventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InventoryGridView.BackgroundColor = Color.White;
            InventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryGridView.GridColor = Color.White;
            InventoryGridView.Location = new Point(12, 256);
            InventoryGridView.Name = "InventoryGridView";
            InventoryGridView.RowHeadersWidth = 51;
            InventoryGridView.Size = new Size(958, 485);
            InventoryGridView.TabIndex = 1;
            InventoryGridView.CellContentDoubleClick += InventoryGridView_CellContentDoubleClick;
            // 
            // pTextBox
            // 
            pTextBox.Location = new Point(12, 188);
            pTextBox.Name = "pTextBox";
            pTextBox.Size = new Size(315, 27);
            pTextBox.TabIndex = 2;
            // 
            // newButton
            // 
            newButton.Font = new Font("Constantia", 12F);
            newButton.Location = new Point(12, 221);
            newButton.Name = "newButton";
            newButton.Size = new Size(315, 29);
            newButton.TabIndex = 3;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Constantia", 12F);
            deleteButton.Location = new Point(655, 221);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(315, 29);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Constantia", 12F);
            saveButton.Location = new Point(334, 221);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(315, 29);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // nTextBox
            // 
            nTextBox.Location = new Point(334, 130);
            nTextBox.Name = "nTextBox";
            nTextBox.Size = new Size(315, 27);
            nTextBox.TabIndex = 6;
            // 
            // sTextBox
            // 
            sTextBox.Location = new Point(12, 130);
            sTextBox.Name = "sTextBox";
            sTextBox.Size = new Size(315, 27);
            sTextBox.TabIndex = 8;
            // 
            // qTextBox
            // 
            qTextBox.Location = new Point(655, 188);
            qTextBox.Name = "qTextBox";
            qTextBox.Size = new Size(315, 27);
            qTextBox.TabIndex = 9;
            // 
            // dTextBox
            // 
            dTextBox.Location = new Point(333, 188);
            dTextBox.Name = "dTextBox";
            dTextBox.Size = new Size(315, 27);
            dTextBox.TabIndex = 10;
            // 
            // cComboBox
            // 
            cComboBox.FormattingEnabled = true;
            cComboBox.Items.AddRange(new object[] { "Automotive", "Hardware", "Groceries", "Health", "Toys" });
            cComboBox.Location = new Point(655, 129);
            cComboBox.Name = "cComboBox";
            cComboBox.Size = new Size(315, 28);
            cComboBox.TabIndex = 11;
            // 
            // sLabel
            // 
            sLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            sLabel.ForeColor = Color.WhiteSmoke;
            sLabel.Location = new Point(12, 102);
            sLabel.Name = "sLabel";
            sLabel.Size = new Size(315, 25);
            sLabel.TabIndex = 12;
            sLabel.Text = "SKU:";
            // 
            // dLabel
            // 
            dLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            dLabel.ForeColor = Color.WhiteSmoke;
            dLabel.Location = new Point(333, 160);
            dLabel.Name = "dLabel";
            dLabel.Size = new Size(315, 25);
            dLabel.TabIndex = 13;
            dLabel.Text = "Description";
            // 
            // pLabel
            // 
            pLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            pLabel.ForeColor = Color.WhiteSmoke;
            pLabel.Location = new Point(12, 160);
            pLabel.Name = "pLabel";
            pLabel.Size = new Size(315, 25);
            pLabel.TabIndex = 14;
            pLabel.Text = "Price:";
            // 
            // qLabel
            // 
            qLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            qLabel.ForeColor = Color.WhiteSmoke;
            qLabel.Location = new Point(655, 160);
            qLabel.Name = "qLabel";
            qLabel.Size = new Size(315, 25);
            qLabel.TabIndex = 15;
            qLabel.Text = "Quantity";
            // 
            // cLabel
            // 
            cLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            cLabel.ForeColor = Color.WhiteSmoke;
            cLabel.Location = new Point(655, 101);
            cLabel.Name = "cLabel";
            cLabel.Size = new Size(315, 25);
            cLabel.TabIndex = 16;
            cLabel.Text = "Category:";
            // 
            // nLabel
            // 
            nLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            nLabel.ForeColor = Color.WhiteSmoke;
            nLabel.Location = new Point(333, 101);
            nLabel.Name = "nLabel";
            nLabel.Size = new Size(315, 25);
            nLabel.TabIndex = 17;
            nLabel.Text = "Name:";
            // 
            // InventoryManagment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(101, 182, 253);
            ClientSize = new Size(982, 753);
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
    }
}
