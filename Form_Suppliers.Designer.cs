namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    partial class Form_Suppliers
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
            this.button_gomainpage = new System.Windows.Forms.Button();
            this.button_AddSupplier = new System.Windows.Forms.Button();
            this.dataGridView_suppliers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // button_gomainpage
            // 
            this.button_gomainpage.Location = new System.Drawing.Point(398, 38);
            this.button_gomainpage.Name = "button_gomainpage";
            this.button_gomainpage.Size = new System.Drawing.Size(136, 72);
            this.button_gomainpage.TabIndex = 8;
            this.button_gomainpage.Text = "Go To Main Page";
            this.button_gomainpage.UseVisualStyleBackColor = true;
            this.button_gomainpage.Click += new System.EventHandler(this.button_gomainpage_Click);
            // 
            // button_AddSupplier
            // 
            this.button_AddSupplier.Location = new System.Drawing.Point(40, 38);
            this.button_AddSupplier.Name = "button_AddSupplier";
            this.button_AddSupplier.Size = new System.Drawing.Size(136, 72);
            this.button_AddSupplier.TabIndex = 7;
            this.button_AddSupplier.Text = "New Supplier";
            this.button_AddSupplier.UseVisualStyleBackColor = true;
            this.button_AddSupplier.Click += new System.EventHandler(this.button_AddSupplier_Click);
            // 
            // dataGridView_suppliers
            // 
            this.dataGridView_suppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_suppliers.Location = new System.Drawing.Point(40, 115);
            this.dataGridView_suppliers.Name = "dataGridView_suppliers";
            this.dataGridView_suppliers.RowHeadersWidth = 51;
            this.dataGridView_suppliers.RowTemplate.Height = 24;
            this.dataGridView_suppliers.Size = new System.Drawing.Size(852, 450);
            this.dataGridView_suppliers.TabIndex = 6;
            // 
            // Form_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 625);
            this.Controls.Add(this.button_gomainpage);
            this.Controls.Add(this.button_AddSupplier);
            this.Controls.Add(this.dataGridView_suppliers);
            this.Name = "Form_Suppliers";
            this.Text = "Form_Suppliers";
            this.Load += new System.EventHandler(this.Form_Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_suppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_gomainpage;
        private System.Windows.Forms.Button button_AddSupplier;
        private System.Windows.Forms.DataGridView dataGridView_suppliers;
    }
}