namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    partial class Form_NewBuy
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
            this.comboBox_SUPPLIER = new System.Windows.Forms.ComboBox();
            this.label_SUPPLIER = new System.Windows.Forms.Label();
            this.label_UNITCOST = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_PRODUCT = new System.Windows.Forms.Label();
            this.label_AMOUNT = new System.Windows.Forms.Label();
            this.comboBox_PRODUCT = new System.Windows.Forms.ComboBox();
            this.textBox_AMOUNT = new System.Windows.Forms.TextBox();
            this.textBox_UNITPRICE = new System.Windows.Forms.TextBox();
            this.textBox_TOTALPRICE = new System.Windows.Forms.TextBox();
            this.label_TOTALPRICE = new System.Windows.Forms.Label();
            this.textBox_SELLINGPRICE = new System.Windows.Forms.TextBox();
            this.label_SELLINGPRICE = new System.Windows.Forms.Label();
            this.label_LASTUSAGEDATE = new System.Windows.Forms.Label();
            this.dateTimePicker_lastusagedate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBox_SUPPLIER
            // 
            this.comboBox_SUPPLIER.FormattingEnabled = true;
            this.comboBox_SUPPLIER.Location = new System.Drawing.Point(233, 105);
            this.comboBox_SUPPLIER.Name = "comboBox_SUPPLIER";
            this.comboBox_SUPPLIER.Size = new System.Drawing.Size(399, 24);
            this.comboBox_SUPPLIER.TabIndex = 29;
            // 
            // label_SUPPLIER
            // 
            this.label_SUPPLIER.AutoSize = true;
            this.label_SUPPLIER.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SUPPLIER.Location = new System.Drawing.Point(97, 105);
            this.label_SUPPLIER.Name = "label_SUPPLIER";
            this.label_SUPPLIER.Size = new System.Drawing.Size(116, 24);
            this.label_SUPPLIER.TabIndex = 28;
            this.label_SUPPLIER.Text = "SUPPLIER";
            // 
            // label_UNITCOST
            // 
            this.label_UNITCOST.AutoSize = true;
            this.label_UNITCOST.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_UNITCOST.Location = new System.Drawing.Point(86, 217);
            this.label_UNITCOST.Name = "label_UNITCOST";
            this.label_UNITCOST.Size = new System.Drawing.Size(127, 24);
            this.label_UNITCOST.TabIndex = 26;
            this.label_UNITCOST.Text = "UNIT COST";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(496, 505);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(136, 72);
            this.button_back.TabIndex = 25;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(77, 505);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(136, 72);
            this.button_Save.TabIndex = 24;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label_PRODUCT
            // 
            this.label_PRODUCT.AutoSize = true;
            this.label_PRODUCT.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_PRODUCT.Location = new System.Drawing.Point(97, 51);
            this.label_PRODUCT.Name = "label_PRODUCT";
            this.label_PRODUCT.Size = new System.Drawing.Size(115, 24);
            this.label_PRODUCT.TabIndex = 22;
            this.label_PRODUCT.Text = "PRODUCT";
            // 
            // label_AMOUNT
            // 
            this.label_AMOUNT.AutoSize = true;
            this.label_AMOUNT.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_AMOUNT.Location = new System.Drawing.Point(111, 162);
            this.label_AMOUNT.Name = "label_AMOUNT";
            this.label_AMOUNT.Size = new System.Drawing.Size(102, 24);
            this.label_AMOUNT.TabIndex = 20;
            this.label_AMOUNT.Text = "AMOUNT";
            // 
            // comboBox_PRODUCT
            // 
            this.comboBox_PRODUCT.FormattingEnabled = true;
            this.comboBox_PRODUCT.Location = new System.Drawing.Point(233, 51);
            this.comboBox_PRODUCT.Name = "comboBox_PRODUCT";
            this.comboBox_PRODUCT.Size = new System.Drawing.Size(399, 24);
            this.comboBox_PRODUCT.TabIndex = 30;
            // 
            // textBox_AMOUNT
            // 
            this.textBox_AMOUNT.Location = new System.Drawing.Point(233, 162);
            this.textBox_AMOUNT.Name = "textBox_AMOUNT";
            this.textBox_AMOUNT.Size = new System.Drawing.Size(399, 22);
            this.textBox_AMOUNT.TabIndex = 31;
            // 
            // textBox_UNITPRICE
            // 
            this.textBox_UNITPRICE.Location = new System.Drawing.Point(233, 217);
            this.textBox_UNITPRICE.Name = "textBox_UNITPRICE";
            this.textBox_UNITPRICE.Size = new System.Drawing.Size(399, 22);
            this.textBox_UNITPRICE.TabIndex = 32;
            this.textBox_UNITPRICE.TextChanged += new System.EventHandler(this.textBox_UNITPRICE_TextChanged);
            // 
            // textBox_TOTALPRICE
            // 
            this.textBox_TOTALPRICE.Enabled = false;
            this.textBox_TOTALPRICE.Location = new System.Drawing.Point(233, 282);
            this.textBox_TOTALPRICE.Name = "textBox_TOTALPRICE";
            this.textBox_TOTALPRICE.Size = new System.Drawing.Size(399, 22);
            this.textBox_TOTALPRICE.TabIndex = 34;
            // 
            // label_TOTALPRICE
            // 
            this.label_TOTALPRICE.AutoSize = true;
            this.label_TOTALPRICE.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_TOTALPRICE.Location = new System.Drawing.Point(58, 280);
            this.label_TOTALPRICE.Name = "label_TOTALPRICE";
            this.label_TOTALPRICE.Size = new System.Drawing.Size(155, 24);
            this.label_TOTALPRICE.TabIndex = 33;
            this.label_TOTALPRICE.Text = "TOTAL PRICE";
            // 
            // textBox_SELLINGPRICE
            // 
            this.textBox_SELLINGPRICE.Location = new System.Drawing.Point(233, 346);
            this.textBox_SELLINGPRICE.Name = "textBox_SELLINGPRICE";
            this.textBox_SELLINGPRICE.Size = new System.Drawing.Size(399, 22);
            this.textBox_SELLINGPRICE.TabIndex = 36;
            // 
            // label_SELLINGPRICE
            // 
            this.label_SELLINGPRICE.AutoSize = true;
            this.label_SELLINGPRICE.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SELLINGPRICE.Location = new System.Drawing.Point(36, 346);
            this.label_SELLINGPRICE.Name = "label_SELLINGPRICE";
            this.label_SELLINGPRICE.Size = new System.Drawing.Size(177, 24);
            this.label_SELLINGPRICE.TabIndex = 35;
            this.label_SELLINGPRICE.Text = "SELLING PRICE";
            // 
            // label_LASTUSAGEDATE
            // 
            this.label_LASTUSAGEDATE.AutoSize = true;
            this.label_LASTUSAGEDATE.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_LASTUSAGEDATE.Location = new System.Drawing.Point(17, 417);
            this.label_LASTUSAGEDATE.Name = "label_LASTUSAGEDATE";
            this.label_LASTUSAGEDATE.Size = new System.Drawing.Size(196, 24);
            this.label_LASTUSAGEDATE.TabIndex = 37;
            this.label_LASTUSAGEDATE.Text = "LASTUSAGEDATE";
            // 
            // dateTimePicker_lastusagedate
            // 
            this.dateTimePicker_lastusagedate.Location = new System.Drawing.Point(233, 418);
            this.dateTimePicker_lastusagedate.Name = "dateTimePicker_lastusagedate";
            this.dateTimePicker_lastusagedate.Size = new System.Drawing.Size(399, 22);
            this.dateTimePicker_lastusagedate.TabIndex = 38;
            this.dateTimePicker_lastusagedate.Value = new System.DateTime(2025, 4, 17, 0, 0, 0, 0);
            this.dateTimePicker_lastusagedate.ValueChanged += new System.EventHandler(this.dateTimePicker_lastusagedate_ValueChanged);
            // 
            // Form_NewBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 646);
            this.Controls.Add(this.dateTimePicker_lastusagedate);
            this.Controls.Add(this.label_LASTUSAGEDATE);
            this.Controls.Add(this.textBox_SELLINGPRICE);
            this.Controls.Add(this.label_SELLINGPRICE);
            this.Controls.Add(this.textBox_TOTALPRICE);
            this.Controls.Add(this.label_TOTALPRICE);
            this.Controls.Add(this.textBox_UNITPRICE);
            this.Controls.Add(this.textBox_AMOUNT);
            this.Controls.Add(this.comboBox_PRODUCT);
            this.Controls.Add(this.comboBox_SUPPLIER);
            this.Controls.Add(this.label_SUPPLIER);
            this.Controls.Add(this.label_UNITCOST);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_PRODUCT);
            this.Controls.Add(this.label_AMOUNT);
            this.Name = "Form_NewBuy";
            this.Text = "Form_NewBuy";
            this.Load += new System.EventHandler(this.Form_NewBuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_SUPPLIER;
        private System.Windows.Forms.Label label_SUPPLIER;
        private System.Windows.Forms.Label label_UNITCOST;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_PRODUCT;
        private System.Windows.Forms.Label label_AMOUNT;
        private System.Windows.Forms.ComboBox comboBox_PRODUCT;
        private System.Windows.Forms.TextBox textBox_AMOUNT;
        private System.Windows.Forms.TextBox textBox_UNITPRICE;
        private System.Windows.Forms.TextBox textBox_TOTALPRICE;
        private System.Windows.Forms.Label label_TOTALPRICE;
        private System.Windows.Forms.TextBox textBox_SELLINGPRICE;
        private System.Windows.Forms.Label label_SELLINGPRICE;
        private System.Windows.Forms.Label label_LASTUSAGEDATE;
        private System.Windows.Forms.DateTimePicker dateTimePicker_lastusagedate;
    }
}