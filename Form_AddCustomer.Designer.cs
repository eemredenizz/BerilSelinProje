namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    partial class Form_AddCustomer
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
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_Surname = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Name.Location = new System.Drawing.Point(51, 66);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(68, 24);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            this.label_Name.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(130, 66);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(400, 22);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Surname.Location = new System.Drawing.Point(22, 147);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(102, 24);
            this.label_Surname.TabIndex = 2;
            this.label_Surname.Text = "Surname";
            this.label_Surname.Click += new System.EventHandler(this.label_Surname_Click);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(130, 147);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(400, 22);
            this.textBox_surname.TabIndex = 3;
            this.textBox_surname.TextChanged += new System.EventHandler(this.textBox_surname_TextChanged);
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Address.Location = new System.Drawing.Point(31, 226);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(88, 24);
            this.label_Address.TabIndex = 4;
            this.label_Address.Text = "Address";
            this.label_Address.Click += new System.EventHandler(this.label_Address_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(130, 229);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(400, 113);
            this.textBox_address.TabIndex = 5;
            this.textBox_address.TextChanged += new System.EventHandler(this.textBox_address_TextChanged);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(130, 417);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(136, 72);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(394, 417);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(136, 72);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Form_AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 583);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_Name);
            this.Name = "Form_AddCustomer";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_back;
    }
}