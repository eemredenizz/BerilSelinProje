namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    partial class Form_MainPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Customers = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_Products = new System.Windows.Forms.Button();
            this.button_Suppliers = new System.Windows.Forms.Button();
            this.button_buying = new System.Windows.Forms.Button();
            this.button_Selling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Customers
            // 
            this.button_Customers.Location = new System.Drawing.Point(42, 41);
            this.button_Customers.Name = "button_Customers";
            this.button_Customers.Size = new System.Drawing.Size(136, 72);
            this.button_Customers.TabIndex = 0;
            this.button_Customers.Text = "Customers";
            this.button_Customers.UseVisualStyleBackColor = true;
            this.button_Customers.Click += new System.EventHandler(this.button_Customers_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(368, 41);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(136, 72);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_Products
            // 
            this.button_Products.Location = new System.Drawing.Point(42, 202);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(136, 72);
            this.button_Products.TabIndex = 2;
            this.button_Products.Text = "Products";
            this.button_Products.UseVisualStyleBackColor = true;
            this.button_Products.Click += new System.EventHandler(this.button_Products_Click);
            // 
            // button_Suppliers
            // 
            this.button_Suppliers.Location = new System.Drawing.Point(368, 202);
            this.button_Suppliers.Name = "button_Suppliers";
            this.button_Suppliers.Size = new System.Drawing.Size(136, 72);
            this.button_Suppliers.TabIndex = 3;
            this.button_Suppliers.Text = "Suppliers";
            this.button_Suppliers.UseVisualStyleBackColor = true;
            this.button_Suppliers.Click += new System.EventHandler(this.button_Suppliers_Click);
            // 
            // button_buying
            // 
            this.button_buying.Location = new System.Drawing.Point(42, 366);
            this.button_buying.Name = "button_buying";
            this.button_buying.Size = new System.Drawing.Size(136, 72);
            this.button_buying.TabIndex = 4;
            this.button_buying.Text = "Buying ";
            this.button_buying.UseVisualStyleBackColor = true;
            this.button_buying.Click += new System.EventHandler(this.button_buying_Click);
            // 
            // button_Selling
            // 
            this.button_Selling.Location = new System.Drawing.Point(368, 366);
            this.button_Selling.Name = "button_Selling";
            this.button_Selling.Size = new System.Drawing.Size(136, 72);
            this.button_Selling.TabIndex = 5;
            this.button_Selling.Text = "Selling";
            this.button_Selling.UseVisualStyleBackColor = true;
            // 
            // Form_MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 642);
            this.Controls.Add(this.button_Selling);
            this.Controls.Add(this.button_buying);
            this.Controls.Add(this.button_Suppliers);
            this.Controls.Add(this.button_Products);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_Customers);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form_MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Customers;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.Button button_Suppliers;
        private System.Windows.Forms.Button button_buying;
        private System.Windows.Forms.Button button_Selling;
    }
}

