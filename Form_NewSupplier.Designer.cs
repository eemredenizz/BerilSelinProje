namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    partial class Form_NewSupplier
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
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_sector = new System.Windows.Forms.TextBox();
            this.label_Sector = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(394, 392);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(136, 72);
            this.button_back.TabIndex = 15;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(130, 392);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(136, 72);
            this.button_Save.TabIndex = 14;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(130, 204);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(400, 113);
            this.textBox_address.TabIndex = 13;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Address.Location = new System.Drawing.Point(31, 201);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(88, 24);
            this.label_Address.TabIndex = 12;
            this.label_Address.Text = "Address";
            // 
            // textBox_sector
            // 
            this.textBox_sector.Location = new System.Drawing.Point(130, 122);
            this.textBox_sector.Name = "textBox_sector";
            this.textBox_sector.Size = new System.Drawing.Size(400, 22);
            this.textBox_sector.TabIndex = 11;
            // 
            // label_Sector
            // 
            this.label_Sector.AutoSize = true;
            this.label_Sector.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Sector.Location = new System.Drawing.Point(43, 122);
            this.label_Sector.Name = "label_Sector";
            this.label_Sector.Size = new System.Drawing.Size(76, 24);
            this.label_Sector.TabIndex = 10;
            this.label_Sector.Text = "Sector";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(130, 41);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(400, 22);
            this.textBox_name.TabIndex = 9;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Name.Location = new System.Drawing.Point(51, 41);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(68, 24);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "Name";
            // 
            // Form_NewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 583);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.textBox_sector);
            this.Controls.Add(this.label_Sector);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_Name);
            this.Name = "Form_NewSupplier";
            this.Text = "Form_NewSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox textBox_sector;
        private System.Windows.Forms.Label label_Sector;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_Name;
    }
}