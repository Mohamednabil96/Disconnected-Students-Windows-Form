namespace SudentsITI.PresentationLayer
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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            txtId = new TextBox();
            lblId = new Label();
            label2 = new Label();
            txtFName = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtLName = new TextBox();
            btninsert = new Button();
            btnupdate = new Button();
            btnDel = new Button();
            labelaffected = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 238);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(406, 293);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // txtId
            // 
            txtId.Location = new Point(138, 293);
            txtId.Name = "txtId";
            txtId.Size = new Size(215, 27);
            txtId.TabIndex = 2;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(44, 296);
            lblId.Name = "lblId";
            lblId.Size = new Size(35, 20);
            lblId.TabIndex = 3;
            lblId.Text = "ID : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 355);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Fname : ";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(138, 352);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(215, 27);
            txtFName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 476);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 9;
            label3.Text = "Address : ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(138, 473);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(215, 27);
            txtAddress.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 417);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 7;
            label4.Text = "Lname : ";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(138, 414);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(215, 27);
            txtLName.TabIndex = 6;
            // 
            // btninsert
            // 
            btninsert.Location = new Point(44, 544);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(94, 29);
            btninsert.TabIndex = 10;
            btninsert.Text = "Insert";
            btninsert.UseVisualStyleBackColor = true;
            btninsert.Click += btninsert_Click_1;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = SystemColors.ActiveCaption;
            btnupdate.Location = new Point(259, 544);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 29);
            btnupdate.TabIndex = 11;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click_1;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Red;
            btnDel.Location = new Point(463, 544);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 12;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click_1;
            // 
            // labelaffected
            // 
            labelaffected.AutoSize = true;
            labelaffected.Location = new Point(655, 548);
            labelaffected.Name = "labelaffected";
            labelaffected.Size = new Size(42, 20);
            labelaffected.TabIndex = 13;
            labelaffected.Text = "label";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 595);
            Controls.Add(labelaffected);
            Controls.Add(btnDel);
            Controls.Add(btnupdate);
            Controls.Add(btninsert);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtLName);
            Controls.Add(label2);
            Controls.Add(txtFName);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox txtId;
        private Label lblId;
        private Label label2;
        private TextBox txtFName;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtLName;
        private Button btninsert;
        private Button btnupdate;
        private Button btnDel;
        private Label labelaffected;
    }
}