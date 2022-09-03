using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupermarketTuto
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        public SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=smarketdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        private void populate()
        {
            Con.Open();
            String query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        /// <summary>
        /// Add a Category in Product View 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            var catFrm = new CategoryForm();
            catFrm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        /// <summary>
        /// This method will bind the Combox with the Database
        /// </summary>
        private void fillCombo(ComboBox  combo)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl",Con);
            SqlDataReader sdr = cmd.ExecuteReader();
         
            DataTable dt = new DataTable();
            //dt.Columns.Add("CatName", typeof(string));
            dt.Columns.Add("CatName",typeof(string));
            dt.Load(sdr);
            combo.ValueMember = "catName";
            combo.DataSource = dt;

            
            Con.Close();
        }
        /// <summary>
        /// Clear TextBox
        /// </summary>
        private void clearProdTb()
        {
            prodIdTb.Text = "";
            ProdNameTb.Text = "";
            ProdQtyTb.Text = "";
            ProdPriceTb.Text = "";
            CatCb.SelectedValue = "";
        }

        
        private void ProductForm_Load(object sender, EventArgs e)
        {
            populate();
            fillCombo(CatCb);
            fillCombo(CatRightTb);
        }

     
        /// <summary>
        /// Add Product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(prodIdTb.Text) || string.IsNullOrEmpty(ProdNameTb.Text) || string.IsNullOrEmpty(ProdQtyTb.Text) || string.IsNullOrEmpty(ProdPriceTb.Text) || string.IsNullOrEmpty(CatCb.Text))
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = $"select count(0) from ProductTbl where ProdId ={prodIdTb.Text}";
                    DataTable dataTable = new DataTable();
                    new SqlDataAdapter(query, Con).Fill(dataTable);
                    if (dataTable.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("The Bill ID is Already Exist.");
                        Con.Close();
                    }


                     query = $"insert into ProductTbl values ({prodIdTb.Text},'{ProdNameTb.Text}','{ProdQtyTb.Text}','{ProdPriceTb.Text}','{CatCb.SelectedValue}')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Add Sucessful!");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add it Again");

            }
        }

        // dataGrid Selected Event
        private void prodDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodIdTb.Text = prodDgv.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTb.Text = prodDgv.SelectedRows[0].Cells[1].Value.ToString();
           ProdQtyTb.Text = prodDgv.SelectedRows[0].Cells[2].Value.ToString();
            ProdPriceTb.Text = prodDgv.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = prodDgv.SelectedRows[0].Cells[4].Value.ToString();
            
        }
        /// <summary>
        /// Delete a Category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(prodIdTb.Text))
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    Con.Open();

                    var query= $"delete from ProductTbl where ProdId={prodIdTb.Text}";
                    new SqlCommand(query, Con).ExecuteNonQuery();
                    MessageBox.Show("Product Deleted  Sucessfully");
                    Con.Close();
                    clearProdTb();
                    populate();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


     
        /// <summary>
        /// Update The Product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(prodIdTb.Text)||string.IsNullOrEmpty(ProdNameTb.Text) || string.IsNullOrEmpty(ProdQtyTb.Text) || string.IsNullOrEmpty(ProdPriceTb.Text) || string.IsNullOrEmpty(CatCb.Text))
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    //UPDATE table_name SET field1=new-value1, field2=new-value2
                    
                    string query = $"update ProductTbl set ProdName ='{ProdNameTb.Text}',ProdQty='{ProdQtyTb.Text}',ProdPrice='{ProdPriceTb.Text}',ProdCat='{CatCb.SelectedValue}' where ProdId ='{prodIdTb.Text}'";
                    new SqlCommand(query, Con).ExecuteNonQuery();
                    MessageBox.Show("Product Updated Sucessfully");
                    Con.Close();
                    clearProdTb();
                    populate();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }
        /// <summary>
        /// Go to Sellers View 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            var sellerdFrm = new SellerForm();
            sellerdFrm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        /// <summary>
        /// Reflesh Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            populate();
        }
        /// <summary>
        /// Drop-down box Select event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            String query = $"select * from ProductTbl where ProdCat ='{CatRightTb.SelectedValue}'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDgv.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
