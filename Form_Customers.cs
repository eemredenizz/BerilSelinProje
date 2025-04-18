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
    
    public partial class Form_Customers : Form
    {
        public Form_Customers()
        {
            InitializeComponent();
        }

        private void Form_Customers_Load(object sender, EventArgs e)
        {
            try
            {
                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "SELECT * FROM Customers";

                using (SqlConnection con = new SqlConnection(con_text))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);  

                        dataGridView_customers.DataSource = dataTable;  
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_gomainpage_Click(object sender, EventArgs e)
        {
            Form_MainPage mainpage = new Form_MainPage();
            mainpage.Show();
            this.Close();

        }

        private void button_AddCustomer_Click(object sender, EventArgs e)
        {
            Form_AddCustomer addcustomer = new Form_AddCustomer();
            addcustomer.Show();
            this.Close();
        }
    }
}
