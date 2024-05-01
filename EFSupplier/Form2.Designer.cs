namespace EFSupplier
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSupplier = new Label();
            textBox1 = new TextBox();
            BtnSearch = new Button();
            BtnDelete = new Button();
            SuspendLayout();
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(74, 108);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(16, 15);
            lblSupplier.TabIndex = 0;
            lblSupplier.Text = "...";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 1;
            // 
            // btnSearch
            // 
            BtnSearch.Location = new Point(324, 41);
            BtnSearch.Name = "btnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            BtnDelete.Location = new Point(424, 41);
            BtnDelete.Name = "btnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 3;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDelete);
            Controls.Add(BtnSearch);
            Controls.Add(textBox1);
            Controls.Add(lblSupplier);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSupplier;
        private TextBox textBox1;
        private Button BtnSearch;
        private Button BtnDelete;
    }
}