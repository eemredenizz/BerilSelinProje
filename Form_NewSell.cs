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
    public partial class Form_NewSell : Form
    {
        public Form_NewSell()
        {
            InitializeComponent();
        }

        private void Form_NewSell_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox_CUSTOMER.Items.Clear();
                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "select CUSTOMERID, CUSTOMERNAME from CUSTOMERS";

                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(con_text))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(dt);

                    comboBox_CUSTOMER.DisplayMember = "CUSTOMERNAME";
                    comboBox_CUSTOMER.ValueMember = "CUSTOMERID";
                    comboBox_CUSTOMER.DataSource = dt;
                }

                comboBox_PRODUCT.Items.Clear();
                string con_text2 = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query2 = "select PRODUCTID,PRODUCTNAME from PRODUCT";

                DataTable dt2 = new DataTable();
                using (SqlConnection con = new SqlConnection(con_text2))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query2, con);
                    da.Fill(dt2);

                    comboBox_PRODUCT.DisplayMember = "PRODUCTNAME";
                    comboBox_PRODUCT.ValueMember = "PRODUCTID";
                    comboBox_PRODUCT.DataSource = dt2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int customerid = Convert.ToInt32(comboBox_CUSTOMER.SelectedValue);
                int productid = Convert.ToInt32(comboBox_PRODUCT.SelectedValue);

                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "INSERT INTO SELLING (PRODUCTID, CUSTOMERID, AMOUNT, UNITPRICE, TOTALPRICE) VALUES (" +
                    productid + ", " + customerid + ", " + textBox_AMOUNT.Text +
                    ", " + textBox_UNITPRICE.Text + ", " + textBox_TOTALPRICE.Text +
                    ")";

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

                string query2 = "UPDATE PRODUCT SET SALESCOUNT = SALESCOUNT + " +
                    textBox_AMOUNT.Text+ "WHERE PRODUCTID = "+ productid;

                using (SqlConnection con = new SqlConnection(con_text))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query2, con))
                    {
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {

                        }
                    }
                    con.Close();
                }

                string query3 = "UPDATE PRODUCT SET STOCK = SALESCOUNT - PURCHASECOUNT";
                using (SqlConnection con = new SqlConnection(con_text))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query3, con))
                    {
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {

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
            Form_Selling form_Selling = new Form_Selling();
            form_Selling.Show();
            this.Close();
        }

        private void textBox_UNITPRICE_TextChanged(object sender, EventArgs e)
        {
            if (textBox_UNITPRICE.Text != "")
            {
                double totalprice;
                totalprice = Convert.ToDouble(textBox_AMOUNT.Text) * Convert.ToDouble(textBox_UNITPRICE.Text);
                textBox_TOTALPRICE.Text = totalprice.ToString();
            }
        }
    }
}
