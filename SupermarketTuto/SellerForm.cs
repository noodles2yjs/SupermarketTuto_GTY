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

namespace SupermarketTuto
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        public SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=smarketdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        private void populate()
        {
            Con.Open();
            String query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sellerDgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        /// <summary>
        /// Add Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(sellerIdTb.Text) || string.IsNullOrEmpty(sellerNameTb.Text) || string.IsNullOrEmpty(sellerAgeTb.Text) || string.IsNullOrEmpty(sellerPhoneTb.Text) || string.IsNullOrEmpty(sellerPassTb.Text))
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();

                    //  insert into ProductTbl values (ProdId,'ProdName','ProdQty','ProdCat')


                    string query = $"insert into SellerTbl values ({sellerIdTb.Text},'{sellerNameTb.Text}','{sellerAgeTb.Text}','{sellerPhoneTb.Text}','{sellerPassTb.Text}')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Add Sucessful!");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void clearSellerTb()
        {
            sellerIdTb.Text = "";
            sellerNameTb.Text = "";
            sellerAgeTb.Text = "";
            sellerPhoneTb.Text = "";
            sellerPassTb.Text = "";
        }
        /// <summary>
        /// Delete Method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(sellerIdTb.Text))
                {
                    MessageBox.Show("Select The Seller to Delete");
                }
                else
                {
                    Con.Open();

                    var query = $"delete from SellerTbl where SellerId={sellerIdTb.Text}";
                    new SqlCommand(query, Con).ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted  Sucessfully");
                    Con.Close();
                    clearSellerTb();
                    populate();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Edit Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(sellerIdTb.Text) || string.IsNullOrEmpty(sellerNameTb.Text) || string.IsNullOrEmpty(sellerAgeTb.Text) || string.IsNullOrEmpty(sellerPhoneTb.Text) || string.IsNullOrEmpty(sellerPassTb.Text))
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    //UPDATE table_name SET field1=new-value1, field2=new-value2

                    string query = $"update SellerTbl set SellerName ='{sellerNameTb.Text}',SellerAge='{sellerAgeTb.Text}',SellerPhone='{sellerPhoneTb.Text}',SellerPass='{sellerPassTb.Text}' where SellerId ='{sellerIdTb.Text}'";
                    new SqlCommand(query, Con).ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Sucessfully");
                    Con.Close();
                    clearSellerTb();
                    populate();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        /// <summary>
        /// sellerDgv_CellContentClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sellerDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sellerIdTb.Text = sellerDgv.SelectedRows[0].Cells[0].Value.ToString();
            sellerNameTb.Text = sellerDgv.SelectedRows[0].Cells[1].Value.ToString();
            sellerAgeTb.Text = sellerDgv.SelectedRows[0].Cells[2].Value.ToString();
            sellerPhoneTb.Text = sellerDgv.SelectedRows[0].Cells[3].Value.ToString();
            sellerPassTb.Text = sellerDgv.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Go to PRODUCTS View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            new ProductForm().Show();
            this.Hide();
        }
        /// <summary>
        /// Go To  CATEGORIES View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            new CategoryForm().Show();
            this.Hide();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
