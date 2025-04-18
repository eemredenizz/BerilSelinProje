using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    public partial class Form_MainPage : Form
    {
        public Form_MainPage()
        {
            InitializeComponent();
        }

        private void Form_MainPage_Load(object sender, EventArgs e)
        {
            try
            {
                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                SqlConnection con = new SqlConnection(con_text);
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_Customers_Click(object sender, EventArgs e)
        {
            Form_Customers fc = new Form_Customers();
            fc.Show();
            this.Hide();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            Form_Stock form_Stock = new Form_Stock();
            form_Stock.Show();
            this.Hide();
        }

        private void button_Suppliers_Click(object sender, EventArgs e)
        {
            Form_Suppliers sp = new Form_Suppliers();
            sp.Show();
            this.Hide();
        }

        private void button_buying_Click(object sender, EventArgs e)
        {
            Form_Buying by = new Form_Buying();
            by.Show();
            this.Hide();
        }

        private void button_Selling_Click(object sender, EventArgs e)
        {
            Form_Selling fs = new Form_Selling();
            fs.Show();
            this.Hide();
        }
    }
}
