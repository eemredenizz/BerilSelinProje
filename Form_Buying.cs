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
    public partial class Form_Buying : Form
    {
        public Form_Buying()
        {
            InitializeComponent();
        }

        private void button_gomainpage_Click(object sender, EventArgs e)
        {
            Form_MainPage form_MainPage = new Form_MainPage();
            form_MainPage.Show();
            this.Close();
        }

        private void Form_Buying_Load(object sender, EventArgs e)
        {
            try
            {
                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "Select pd.PRODUCTNO,pd.PRODUCTNAME,sp.SUPPLIERNAME, bu.AMOUNT, bu.UNITPRICE, bu.TOTALPRICE FROM BUYING AS bu\r\njoin SUPPLIERS  as sp on sp.SUPPLIERID = bu.SUPPLIERID\r\njoin PRODUCT as pd on pd.PRODUCTID = bu.PRODUCTID";

                using (SqlConnection con = new SqlConnection(con_text))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView_buying.DataSource = dataTable;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
