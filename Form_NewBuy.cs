using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelinKeyik_AyseBerilAksu_MehmetcanAlptekin
{
    public partial class Form_NewBuy : Form
    {
        public Form_NewBuy()
        {
            InitializeComponent();
        }

        private void Form_NewBuy_Load(object sender, EventArgs e)
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
                int supplierid = Convert.ToInt32(comboBox_SUPPLIER.SelectedValue);
                int productid = Convert.ToInt32(comboBox_PRODUCT.SelectedValue);

                string con_text = "Server=DESKTOP-N4C6F2N; Database=PROJECT; Integrated Security=true;";
                string query = "INSERT INTO BUYING (PRODUCTID, SUPPLIERID, AMOUNT, UNITPRICE, TOTALPRICE) VALUES (" +
                    productid + ", " + supplierid + ", " + textBox_AMOUNT.Text +
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

                string query2 = "UPDATE PRODUCTSTOCK " +
                                "SET " +
                                "LASTUSAGEDATE = '" + dateTimePicker_lastusagedate.Value.ToString("MM.dd.yyyy") + "', " +
                                "COST = " + textBox_UNITPRICE.Text + ", " +
                                "SELLINGPRICE = " + textBox_SELLINGPRICE.Text + ", " +
                                "AMOUNT = AMOUNT + " + textBox_AMOUNT.Text;

                using (SqlConnection con = new SqlConnection(con_text))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query2, con))
                    {
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            // Başarılı işlem için opsiyonel kod
                        }
                    }
                    con.Close();
                }
                string query3 = "UPDATE PRODUCT SET PURCHASECOUNT = PURCHASECOUNT + " +
                textBox_AMOUNT.Text + "WHERE PRODUCTID = " + productid;

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

                string query4 = "UPDATE PRODUCT SET STOCK = SALESCOUNT - PURCHASECOUNT";
                using (SqlConnection con = new SqlConnection(con_text))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query4, con))
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

        private void textBox_UNITPRICE_TextChanged(object sender, EventArgs e)
        {
            if (textBox_UNITPRICE.Text != "")
            {
                double totalprice;
                totalprice = Convert.ToDouble(textBox_AMOUNT.Text) * Convert.ToDouble(textBox_UNITPRICE.Text);
                textBox_TOTALPRICE.Text = totalprice.ToString();
            }
            
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_Buying form_Buying = new Form_Buying();
            form_Buying.Show();
            this.Close();
        }

        private void dateTimePicker_lastusagedate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
