namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    partial class Form_Stock
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
            this.button_AddStock = new System.Windows.Forms.Button();
            this.dataGridView_stocks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stocks)).BeginInit();
            this.SuspendLayout();
            // 
            // button_gomainpage
            // 
            this.button_gomainpage.Location = new System.Drawing.Point(395, 34);
            this.button_gomainpage.Name = "button_gomainpage";
            this.button_gomainpage.Size = new System.Drawing.Size(136, 72);
            this.button_gomainpage.TabIndex = 5;
            this.button_gomainpage.Text = "Go To Main Page";
            this.button_gomainpage.UseVisualStyleBackColor = true;
            this.button_gomainpage.Click += new System.EventHandler(this.button_gomainpage_Click);
            // 
            // button_AddStock
            // 
            this.button_AddStock.Location = new System.Drawing.Point(37, 34);
            this.button_AddStock.Name = "button_AddStock";
            this.button_AddStock.Size = new System.Drawing.Size(136, 72);
            this.button_AddStock.TabIndex = 4;
            this.button_AddStock.Text = "New Stock";
            this.button_AddStock.UseVisualStyleBackColor = true;
            this.button_AddStock.Click += new System.EventHandler(this.button_AddStock_Click);
            // 
            // dataGridView_stocks
            // 
            this.dataGridView_stocks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stocks.Location = new System.Drawing.Point(37, 111);
            this.dataGridView_stocks.Name = "dataGridView_stocks";
            this.dataGridView_stocks.RowHeadersWidth = 51;
            this.dataGridView_stocks.RowTemplate.Height = 24;
            this.dataGridView_stocks.Size = new System.Drawing.Size(852, 450);
            this.dataGridView_stocks.TabIndex = 3;
            // 
            // Form_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 625);
            this.Controls.Add(this.button_gomainpage);
            this.Controls.Add(this.button_AddStock);
            this.Controls.Add(this.dataGridView_stocks);
            this.Name = "Form_Stock";
            this.Text = "Form_Stock";
            this.Load += new System.EventHandler(this.Form_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_gomainpage;
        private System.Windows.Forms.Button button_AddStock;
        private System.Windows.Forms.DataGridView dataGridView_stocks;
    }
}