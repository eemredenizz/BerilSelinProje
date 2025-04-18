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
    public partial class Form_Selling : Form
    {
        public Form_Selling()
        {
            InitializeComponent();
        }

        private void Form_Selling_Load(object sender, EventArgs e)
        {
            try
            {
                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "SELECT ct.CUSTOMERNAME,pd.PRODUCTNAME,sl.UNITPRICE,sl.AMOUNT,sl.TOTALPRICE FROM SELLING as sl \r\njoin CUSTOMERS as ct on ct.CUSTOMERID = sl.CUSTOMERID\r\njoin PRODUCT as pd on pd.PRODUCTID = sl.PRODUCTID\r\n";
                using (SqlConnection con = new SqlConnection(con_text))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView_selling.DataSource = dataTable;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_NewSell_Click(object sender, EventArgs e)
        {
            Form_NewSell fnws = new Form_NewSell();
            fnws.Show();
            this.Close();
        }

        private void button_gomainpage_Click(object sender, EventArgs e)
        {
            Form_MainPage fnws = new Form_MainPage();
            fnws.Show();
            this.Close();
        }
    }
}
