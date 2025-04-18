using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    public partial class Form_NewStock : Form
    {
        private List suplliers;
        public Form_NewStock()
        {
            InitializeComponent();
        }

        private void Form_NewStock_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox_SUPPLIER.Items.Clear();
                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "select SUPPLIERID, SUPPLIERNAME from SUPPLIERS";

                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(con_text))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(dt);

                    comboBox_SUPPLIER.DisplayMember = "SUPPLIERNAME";  
                    comboBox_SUPPLIER.ValueMember = "SUPPLIERID";      
                    comboBox_SUPPLIER.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_MainPage mainpage = new Form_MainPage();
            mainpage.Show();
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int supplierid = Convert.ToInt32(comboBox_SUPPLIER.SelectedValue);
                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "INSERT INTO PRODUCT (PRODUCTNO, PRODUCTNAME, BARCODE, SUPPLIER) VALUES ('" + textBox_PRODUCTNO.Text +
                    "', '" + textBox_PRODUCTNAME.Text + "', '" + textBox_BARCODE.Text + "', " + supplierid + ")";
                             

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
    }
}
