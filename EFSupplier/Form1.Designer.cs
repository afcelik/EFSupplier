namespace EFSupplier
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCompanyName = new TextBox();
            txtContactName = new TextBox();
            txtContactTitle = new TextBox();
            txtAddress = new TextBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 42);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Company Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 92);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Contact Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 138);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Contact Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 190);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(123, 34);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(199, 23);
            txtCompanyName.TabIndex = 4;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(123, 84);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(199, 23);
            txtContactName.TabIndex = 5;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(123, 130);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(199, 23);
            txtContactTitle.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(123, 182);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(199, 23);
            txtAddress.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(409, 237);
            dataGridView1.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(247, 248);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(txtAddress);
            Controls.Add(txtContactTitle);
            Controls.Add(txtContactName);
            Controls.Add(txtCompanyName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private TextBox txtContactTitle;
        private TextBox txtAddress;
        private DataGridView dataGridView1;
        private Button btnAdd;
    }
}