namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    partial class Form_Buying
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
            this.button_NewBuy = new System.Windows.Forms.Button();
            this.dataGridView_buying = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buying)).BeginInit();
            this.SuspendLayout();
            // 
            // button_gomainpage
            // 
            this.button_gomainpage.Location = new System.Drawing.Point(365, 27);
            this.button_gomainpage.Name = "button_gomainpage";
            this.button_gomainpage.Size = new System.Drawing.Size(136, 72);
            this.button_gomainpage.TabIndex = 5;
            this.button_gomainpage.Text = "Go To Main Page";
            this.button_gomainpage.UseVisualStyleBackColor = true;
            this.button_gomainpage.Click += new System.EventHandler(this.button_gomainpage_Click);
            // 
            // button_NewBuy
            // 
            this.button_NewBuy.Location = new System.Drawing.Point(25, 27);
            this.button_NewBuy.Name = "button_NewBuy";
            this.button_NewBuy.Size = new System.Drawing.Size(136, 72);
            this.button_NewBuy.TabIndex = 4;
            this.button_NewBuy.Text = "New Buy";
            this.button_NewBuy.UseVisualStyleBackColor = true;
            // 
            // dataGridView_buying
            // 
            this.dataGridView_buying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_buying.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buying.Location = new System.Drawing.Point(25, 104);
            this.dataGridView_buying.Name = "dataGridView_buying";
            this.dataGridView_buying.RowHeadersWidth = 51;
            this.dataGridView_buying.RowTemplate.Height = 24;
            this.dataGridView_buying.Size = new System.Drawing.Size(852, 450);
            this.dataGridView_buying.TabIndex = 3;
            // 
            // Form_Buying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 625);
            this.Controls.Add(this.button_gomainpage);
            this.Controls.Add(this.button_NewBuy);
            this.Controls.Add(this.dataGridView_buying);
            this.Name = "Form_Buying";
            this.Text = "Form_Buying";
            this.Load += new System.EventHandler(this.Form_Buying_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buying)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_gomainpage;
        private System.Windows.Forms.Button button_NewBuy;
        private System.Windows.Forms.DataGridView dataGridView_buying;
    }
}