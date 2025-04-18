namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    partial class Form_NewStock
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_PRODUCTNO = new System.Windows.Forms.TextBox();
            this.label_PRODUCTNO = new System.Windows.Forms.Label();
            this.textBox_PRODUCTNAME = new System.Windows.Forms.TextBox();
            this.label_PRODUCTNAME = new System.Windows.Forms.Label();
            this.label_BARCODE = new System.Windows.Forms.Label();
            this.textBox_BARCODE = new System.Windows.Forms.TextBox();
            this.label_SUPPLIER = new System.Windows.Forms.Label();
            this.comboBox_SUPPLIER = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(451, 350);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(136, 72);
            this.button_back.TabIndex = 15;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(187, 350);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(136, 72);
            this.button_Save.TabIndex = 14;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_PRODUCTNO
            // 
            this.textBox_PRODUCTNO.Location = new System.Drawing.Point(187, 57);
            this.textBox_PRODUCTNO.Name = "textBox_PRODUCTNO";
            this.textBox_PRODUCTNO.Size = new System.Drawing.Size(400, 22);
            this.textBox_PRODUCTNO.TabIndex = 11;
            // 
            // label_PRODUCTNO
            // 
            this.label_PRODUCTNO.AutoSize = true;
            this.label_PRODUCTNO.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_PRODUCTNO.Location = new System.Drawing.Point(35, 57);
            this.label_PRODUCTNO.Name = "label_PRODUCTNO";
            this.label_PRODUCTNO.Size = new System.Drawing.Size(146, 24);
            this.label_PRODUCTNO.TabIndex = 10;
            this.label_PRODUCTNO.Text = "PRODUCTNO";
            // 
            // textBox_PRODUCTNAME
            // 
            this.textBox_PRODUCTNAME.Location = new System.Drawing.Point(187, 115);
            this.textBox_PRODUCTNAME.Name = "textBox_PRODUCTNAME";
            this.textBox_PRODUCTNAME.Size = new System.Drawing.Size(400, 22);
            this.textBox_PRODUCTNAME.TabIndex = 9;
            // 
            // label_PRODUCTNAME
            // 
            this.label_PRODUCTNAME.AutoSize = true;
            this.label_PRODUCTNAME.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_PRODUCTNAME.Location = new System.Drawing.Point(4, 113);
            this.label_PRODUCTNAME.Name = "label_PRODUCTNAME";
            this.label_PRODUCTNAME.Size = new System.Drawing.Size(177, 24);
            this.label_PRODUCTNAME.TabIndex = 8;
            this.label_PRODUCTNAME.Text = "PRODUCTNAME";
            // 
            // label_BARCODE
            // 
            this.label_BARCODE.AutoSize = true;
            this.label_BARCODE.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_BARCODE.Location = new System.Drawing.Point(65, 176);
            this.label_BARCODE.Name = "label_BARCODE";
            this.label_BARCODE.Size = new System.Drawing.Size(116, 24);
            this.label_BARCODE.TabIndex = 16;
            this.label_BARCODE.Text = "BARCODE";
            // 
            // textBox_BARCODE
            // 
            this.textBox_BARCODE.Location = new System.Drawing.Point(187, 176);
            this.textBox_BARCODE.Name = "textBox_BARCODE";
            this.textBox_BARCODE.Size = new System.Drawing.Size(400, 22);
            this.textBox_BARCODE.TabIndex = 17;
            // 
            // label_SUPPLIER
            // 
            this.label_SUPPLIER.AutoSize = true;
            this.label_SUPPLIER.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SUPPLIER.Location = new System.Drawing.Point(65, 255);
            this.label_SUPPLIER.Name = "label_SUPPLIER";
            this.label_SUPPLIER.Size = new System.Drawing.Size(116, 24);
            this.label_SUPPLIER.TabIndex = 18;
            this.label_SUPPLIER.Text = "SUPPLIER";
            // 
            // comboBox_SUPPLIER
            // 
            this.comboBox_SUPPLIER.FormattingEnabled = true;
            this.comboBox_SUPPLIER.Location = new System.Drawing.Point(188, 254);
            this.comboBox_SUPPLIER.Name = "comboBox_SUPPLIER";
            this.comboBox_SUPPLIER.Size = new System.Drawing.Size(399, 24);
            this.comboBox_SUPPLIER.TabIndex = 19;
            // 
            // Form_NewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 583);
            this.Controls.Add(this.comboBox_SUPPLIER);
            this.Controls.Add(this.label_SUPPLIER);
            this.Controls.Add(this.textBox_BARCODE);
            this.Controls.Add(this.label_BARCODE);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_PRODUCTNO);
            this.Controls.Add(this.label_PRODUCTNO);
            this.Controls.Add(this.textBox_PRODUCTNAME);
            this.Controls.Add(this.label_PRODUCTNAME);
            this.Name = "Form_NewStock";
            this.Text = "Form_NewStock";
            this.Load += new System.EventHandler(this.Form_NewStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_PRODUCTNO;
        private System.Windows.Forms.Label label_PRODUCTNO;
        private System.Windows.Forms.TextBox textBox_PRODUCTNAME;
        private System.Windows.Forms.Label label_PRODUCTNAME;
        private System.Windows.Forms.Label label_BARCODE;
        private System.Windows.Forms.TextBox textBox_BARCODE;
        private System.Windows.Forms.Label label_SUPPLIER;
        private System.Windows.Forms.ComboBox comboBox_SUPPLIER;
    }
}