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
    public partial class Form_NewSupplier : Form
    {
        public Form_NewSupplier()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "INSERT INTO SUPPLIERS (SUPPLIERNAME, SECTOR, ADDRESS) VALUES ('" +
                              textBox_name.Text + "', '" +
                              textBox_sector.Text + "', '" +
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
            Form_Suppliers form_Suppliers = new Form_Suppliers();
            form_Suppliers.Show();
            this.Close();
        }
    }
}
