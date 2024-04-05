namespace Asm
{
    partial class ShowInformation
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
            dataGridView1 = new DataGridView();
            txID = new DataGridViewTextBoxColumn();
            txName = new DataGridViewTextBoxColumn();
            txTypeCustomer = new DataGridViewTextBoxColumn();
            txLastMonthWaterReading = new DataGridViewTextBoxColumn();
            txThisMonthWaterReading = new DataGridViewTextBoxColumn();
            txWaterConsume = new DataGridViewTextBoxColumn();
            txVAT = new DataGridViewTextBoxColumn();
            txWaterBill = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBoxTypeCustomer = new ComboBox();
            textName = new TextBox();
            textID = new TextBox();
            btnSort = new Button();
            btnLogout = new Button();
            label6 = new Label();
            label7 = new Label();
            textLastMonth = new TextBox();
            textThisMonth = new TextBox();
            comboBoxSort = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txID, txName, txTypeCustomer, txLastMonthWaterReading, txThisMonthWaterReading, txWaterConsume, txVAT, txWaterBill });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(57, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1023, 263);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txID
            // 
            txID.HeaderText = "ID";
            txID.Name = "txID";
            txID.Width = 80;
            // 
            // txName
            // 
            txName.HeaderText = "Name";
            txName.Name = "txName";
            txName.Width = 150;
            // 
            // txTypeCustomer
            // 
            txTypeCustomer.HeaderText = "Type Customer";
            txTypeCustomer.Name = "txTypeCustomer";
            txTypeCustomer.Width = 250;
            // 
            // txLastMonthWaterReading
            // 
            txLastMonthWaterReading.HeaderText = "Last Month Water Reading (m3)";
            txLastMonthWaterReading.Name = "txLastMonthWaterReading";
            // 
            // txThisMonthWaterReading
            // 
            txThisMonthWaterReading.HeaderText = "This Month Water Reading (m3)";
            txThisMonthWaterReading.Name = "txThisMonthWaterReading";
            // 
            // txWaterConsume
            // 
            txWaterConsume.HeaderText = "Water Consume (m3)";
            txWaterConsume.Name = "txWaterConsume";
            // 
            // txVAT
            // 
            txVAT.HeaderText = "VAT (VND)";
            txVAT.Name = "txVAT";
            // 
            // txWaterBill
            // 
            txWaterBill.HeaderText = "Water Bill (VND)";
            txWaterBill.Name = "txWaterBill";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(609, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += buttonAdd;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(894, 219);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 31;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += buttonEdit;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(753, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += buttonDelete;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(894, 60);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 29;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += buttonEdit;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 227);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 27;
            label5.Text = "Type Customer";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 68);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 25;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 15);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 24;
            label2.Text = "ID";
            // 
            // comboBoxTypeCustomer
            // 
            comboBoxTypeCustomer.FormattingEnabled = true;
            comboBoxTypeCustomer.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            comboBoxTypeCustomer.Location = new Point(237, 224);
            comboBoxTypeCustomer.Name = "comboBoxTypeCustomer";
            comboBoxTypeCustomer.Size = new Size(236, 23);
            comboBoxTypeCustomer.TabIndex = 23;
            // 
            // textName
            // 
            textName.Location = new Point(237, 65);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.Size = new Size(238, 23);
            textName.TabIndex = 19;
            // 
            // textID
            // 
            textID.Location = new Point(237, 7);
            textID.Multiline = true;
            textID.Name = "textID";
            textID.Size = new Size(238, 23);
            textID.TabIndex = 18;
            textID.TextChanged += textID_TextChanged;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(611, 145);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 35;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += buttonSort;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(609, 219);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 36;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += buttonLogout;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 121);
            label6.Name = "label6";
            label6.Size = new Size(175, 15);
            label6.TabIndex = 41;
            label6.Text = "Last Month Water Reading (m3)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 179);
            label7.Name = "label7";
            label7.Size = new Size(175, 15);
            label7.TabIndex = 40;
            label7.Text = "This Month Water Reading (m3)";
            // 
            // textLastMonth
            // 
            textLastMonth.Location = new Point(237, 118);
            textLastMonth.Multiline = true;
            textLastMonth.Name = "textLastMonth";
            textLastMonth.Size = new Size(236, 23);
            textLastMonth.TabIndex = 39;
            // 
            // textThisMonth
            // 
            textThisMonth.Location = new Point(237, 176);
            textThisMonth.Multiline = true;
            textThisMonth.Name = "textThisMonth";
            textThisMonth.Size = new Size(236, 23);
            textThisMonth.TabIndex = 38;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "ID", "Name", "Type Customer", "Water Consume", "VAT", "Water Bill" });
            comboBoxSort.Location = new Point(692, 146);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(236, 23);
            comboBoxSort.TabIndex = 42;
            comboBoxSort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ShowInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 601);
            Controls.Add(comboBoxSort);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textLastMonth);
            Controls.Add(textThisMonth);
            Controls.Add(btnLogout);
            Controls.Add(btnSort);
            Controls.Add(btnAdd);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxTypeCustomer);
            Controls.Add(textName);
            Controls.Add(textID);
            Controls.Add(dataGridView1);
            Name = "ShowInformation";
            Text = "Show Information";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnExit;
        private Button btnDelete;
        private Button btnEdit;
        private Label label5;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxTypeCustomer;
        private TextBox textName;
        private TextBox textID;
        private Button btnSort;
        private Button btnLogout;
        private Label label6;
        private Label label7;
        private TextBox textLastMonth;
        private TextBox textThisMonth;
        private ComboBox comboBoxSort;
        private DataGridViewTextBoxColumn txID;
        private DataGridViewTextBoxColumn txName;
        private DataGridViewTextBoxColumn txTypeCustomer;
        private DataGridViewTextBoxColumn txLastMonthWaterReading;
        private DataGridViewTextBoxColumn txThisMonthWaterReading;
        private DataGridViewTextBoxColumn txWaterConsume;
        private DataGridViewTextBoxColumn txVAT;
        private DataGridViewTextBoxColumn txWaterBill;
    }
}
