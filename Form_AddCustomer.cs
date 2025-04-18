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
    public partial class Form_AddCustomer : Form
    {
        public Form_AddCustomer()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "INSERT INTO CUSTOMERS (CUSTOMERNAME, CUSTOMERSURNAME, ADDRESS) VALUES ('" +
                              textBox_name.Text + "', '" +
                              textBox_surname.Text + "', '" +
                              textBox_address.Text + "')";

                using (SqlConnection con = new SqlConnection(con_text))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla eklendi!");
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_Customers fc = new Form_Customers();
            fc.Show();
            this.Close();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Surname_Click(object sender, EventArgs e)
        {

        }

        private void textBox_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Address_Click(object sender, EventArgs e)
        {

        }

        private void textBox_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Name_Click(object sender, EventArgs e)
        {

        }
    }
}
