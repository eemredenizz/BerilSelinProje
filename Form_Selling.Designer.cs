namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    partial class Form_Selling
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
            this.button_NewSell = new System.Windows.Forms.Button();
            this.dataGridView_selling = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selling)).BeginInit();
            this.SuspendLayout();
            // 
            // button_gomainpage
            // 
            this.button_gomainpage.Location = new System.Drawing.Point(383, 39);
            this.button_gomainpage.Name = "button_gomainpage";
            this.button_gomainpage.Size = new System.Drawing.Size(136, 72);
            this.button_gomainpage.TabIndex = 8;
            this.button_gomainpage.Text = "Go To Main Page";
            this.button_gomainpage.UseVisualStyleBackColor = true;
            this.button_gomainpage.Click += new System.EventHandler(this.button_gomainpage_Click);
            // 
            // button_NewSell
            // 
            this.button_NewSell.Location = new System.Drawing.Point(43, 39);
            this.button_NewSell.Name = "button_NewSell";
            this.button_NewSell.Size = new System.Drawing.Size(136, 72);
            this.button_NewSell.TabIndex = 7;
            this.button_NewSell.Text = "New Sell";
            this.button_NewSell.UseVisualStyleBackColor = true;
            this.button_NewSell.Click += new System.EventHandler(this.button_NewSell_Click);
            // 
            // dataGridView_selling
            // 
            this.dataGridView_selling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_selling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_selling.Location = new System.Drawing.Point(43, 116);
            this.dataGridView_selling.Name = "dataGridView_selling";
            this.dataGridView_selling.RowHeadersWidth = 51;
            this.dataGridView_selling.RowTemplate.Height = 24;
            this.dataGridView_selling.Size = new System.Drawing.Size(852, 450);
            this.dataGridView_selling.TabIndex = 6;
            // 
            // Form_Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 625);
            this.Controls.Add(this.button_gomainpage);
            this.Controls.Add(this.button_NewSell);
            this.Controls.Add(this.dataGridView_selling);
            this.Name = "Form_Selling";
            this.Text = "Form_Selling";
            this.Load += new System.EventHandler(this.Form_Selling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_gomainpage;
        private System.Windows.Forms.Button button_NewSell;
        private System.Windows.Forms.DataGridView dataGridView_selling;
    }
}