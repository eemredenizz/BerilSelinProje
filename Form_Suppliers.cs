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
    public partial class Form_Suppliers : Form
    {
        public Form_Suppliers()
        {
            InitializeComponent();
        }

        private void button_gomainpage_Click(object sender, EventArgs e)
        {
            Form_MainPage mp = new Form_MainPage();
            mp.Show();
            this.Close();
        }

        private void Form_Suppliers_Load(object sender, EventArgs e)
        {
            try
            {
                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "Select SUPPLIERNAME, ADDRESS, SECTOR FROM SUPPLIERS";

                using (SqlConnection con = new SqlConnection(con_text))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView_suppliers.DataSource = dataTable;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_AddSupplier_Click(object sender, EventArgs e)
        {
            Form_NewSupplier supplier = new Form_NewSupplier();
            supplier.Show();
            this.Close();
        }
    }
}
