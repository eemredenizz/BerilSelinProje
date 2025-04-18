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
    public partial class Form_Stock : Form
    {
        public Form_Stock()
        {
            InitializeComponent();
        }

        private void Form_Stock_Load(object sender, EventArgs e)
        {
            try
            {
                string query_updatestock = "UPDATE PRODUCT SET STOCK = PURCHASECOUNT - SALESCOUNT";
                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "SELECT pr.PRODUCTNO, pr.PRODUCTNAME, STOCK,SUPPLIER,pr.BARCODE, ps.LASTUSAGEDATE, ps.COST, ps.SELLINGPRICE, ps.AMOUNT FROM PRODUCT as pr\r\njoin PRODUCTSTOCKS as ps on ps.PRODUCTID = pr.PRODUCTID";
                using (SqlConnection con = new SqlConnection(con_text))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query_updatestock, con))
                    {
                      cmd.ExecuteNonQuery();

                    }
                    con.Close();
                }


                using (SqlConnection con = new SqlConnection(con_text))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView_stocks.DataSource = dataTable;
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
            Form_MainPage fm = new Form_MainPage();
            fm.Show();
            this.Close();
        }

        private void button_AddStock_Click(object sender, EventArgs e)
        {
            Form_NewStock newStock = new Form_NewStock();
            newStock.Show();
            this.Close();
        }
    }
}
