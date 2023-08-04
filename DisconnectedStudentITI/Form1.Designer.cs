namespace DisconnectedStudentITI
{
    partial class Form1
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
            gridStudents = new DataGridView();
            txtID = new TextBox();
            txtAddress = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            lblID = new Label();
            lblFName = new Label();
            lblLName = new Label();
            lblAddress = new Label();
            lblResult = new Label();
            btnInsert = new Button();
            btnSync = new Button();
            lblAge = new Label();
            txtAge = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridStudents).BeginInit();
            SuspendLayout();
            // 
            // gridStudents
            // 
            gridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudents.Dock = DockStyle.Top;
            gridStudents.Location = new Point(0, 0);
            gridStudents.Name = "gridStudents";
            gridStudents.RowHeadersWidth = 51;
            gridStudents.RowTemplate.Height = 29;
            gridStudents.Size = new Size(800, 239);
            gridStudents.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(104, 302);
            txtID.Name = "txtID";
            txtID.Size = new Size(186, 27);
            txtID.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(473, 302);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(186, 27);
            txtAddress.TabIndex = 2;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(104, 429);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(186, 27);
            txtLName.TabIndex = 3;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(104, 363);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(186, 27);
            txtFName.TabIndex = 4;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(28, 302);
            lblID.Name = "lblID";
            lblID.Size = new Size(35, 20);
            lblID.TabIndex = 5;
            lblID.Text = "ID : ";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(28, 363);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(67, 20);
            lblFName.TabIndex = 6;
            lblFName.Text = "FName : ";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(28, 429);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(67, 20);
            lblLName.TabIndex = 7;
            lblLName.Text = "LName : ";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(397, 302);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(73, 20);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address : ";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(675, 576);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 9;
            lblResult.Text = "Result";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(121, 572);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnSync
            // 
            btnSync.BackColor = Color.Green;
            btnSync.FlatAppearance.BorderSize = 0;
            btnSync.FlatStyle = FlatStyle.Flat;
            btnSync.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSync.Location = new Point(376, 572);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(94, 29);
            btnSync.TabIndex = 11;
            btnSync.Text = "Sync.";
            btnSync.UseVisualStyleBackColor = false;
            btnSync.Click += btnSync_Click;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(397, 363);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(47, 20);
            lblAge.TabIndex = 13;
            lblAge.Text = "Age : ";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(473, 363);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(186, 27);
            txtAge.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 629);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(btnSync);
            Controls.Add(btnInsert);
            Controls.Add(lblResult);
            Controls.Add(lblAddress);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Controls.Add(lblID);
            Controls.Add(txtFName);
            Controls.Add(txtLName);
            Controls.Add(txtAddress);
            Controls.Add(txtID);
            Controls.Add(gridStudents);
            Name = "Form1";
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)gridStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridStudents;
        private TextBox txtID;
        private TextBox txtAddress;
        private TextBox txtLName;
        private TextBox txtFName;
        private Label lblID;
        private Label lblFName;
        private Label lblLName;
        private Label lblAddress;
        private Label lblResult;
        private Button btnInsert;
        private Button btnSync;
        private Label lblAge;
        private TextBox txtAge;
    }
}