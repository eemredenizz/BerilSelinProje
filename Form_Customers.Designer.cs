namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    partial class Form_Customers
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
            this.dataGridView_customers = new System.Windows.Forms.DataGridView();
            this.button_AddCustomer = new System.Windows.Forms.Button();
            this.button_gomainpage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_customers
            // 
            this.dataGridView_customers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customers.Location = new System.Drawing.Point(38, 89);
            this.dataGridView_customers.Name = "dataGridView_customers";
            this.dataGridView_customers.RowHeadersWidth = 51;
            this.dataGridView_customers.RowTemplate.Height = 24;
            this.dataGridView_customers.Size = new System.Drawing.Size(852, 450);
            this.dataGridView_customers.TabIndex = 0;
            // 
            // button_AddCustomer
            // 
            this.button_AddCustomer.Location = new System.Drawing.Point(38, 12);
            this.button_AddCustomer.Name = "button_AddCustomer";
            this.button_AddCustomer.Size = new System.Drawing.Size(136, 72);
            this.button_AddCustomer.TabIndex = 1;
            this.button_AddCustomer.Text = "New Customer";
            this.button_AddCustomer.UseVisualStyleBackColor = true;
            this.button_AddCustomer.Click += new System.EventHandler(this.button_AddCustomer_Click);
            // 
            // button_gomainpage
            // 
            this.button_gomainpage.Location = new System.Drawing.Point(378, 12);
            this.button_gomainpage.Name = "button_gomainpage";
            this.button_gomainpage.Size = new System.Drawing.Size(136, 72);
            this.button_gomainpage.TabIndex = 2;
            this.button_gomainpage.Text = "Go To Main Page";
            this.button_gomainpage.UseVisualStyleBackColor = true;
            this.button_gomainpage.Click += new System.EventHandler(this.button_gomainpage_Click);
            // 
            // Form_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 625);
            this.Controls.Add(this.button_gomainpage);
            this.Controls.Add(this.button_AddCustomer);
            this.Controls.Add(this.dataGridView_customers);
            this.Name = "Form_Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Form_Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_customers;
        private System.Windows.Forms.Button button_AddCustomer;
        private System.Windows.Forms.Button button_gomainpage;
    }
}