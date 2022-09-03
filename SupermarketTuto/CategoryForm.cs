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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

       
        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=smarketdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                // insert into Tbl values(1 ,'面类','面类描述');

                //string query = "insert into CategoryTbl values("+CatIdTb.Text+",'"+CatNameTb.Text+") ";

                string query = "insert into CategoryTbl values ("+ CatIdTb.Text + ",'"+ CatNameTb.Text + "','"+CatDescTb.Text+"')";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Add Sucessful!");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void populate()
        {
            Con.Open();
            String query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];  
            Con.Close();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        /// <summary>
        /// CatDGV_CellContentClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CatIdTb.Text))
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    Con.Open();
                    // DELETE FROM 表名称 WHERE 列名称 = 值
                    //string query = $"delete from CategoryTbl where CatId={int.Parse(CatIdTb.Text)}";
                    //string query = $"delete from CategoryTbl where CatId={int.Parse(CatIdTb.Text)}";
                    string query = $"delete from CategoryTbl where CatId={CatIdTb.Text}";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted  Sucessfully");
                   
                    Con.Close();
                    populate();

                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(CatIdTb.Text) || string.IsNullOrEmpty(CatNameTb.Text) || string.IsNullOrEmpty(CatDescTb.Text))
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = $"update CategoryTbl set CatName='{CatNameTb.Text}' where CatId ={CatIdTb.Text}";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category  Updated Sucessfully ");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Go to Product View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            var prodFrm = new ProductForm();
            prodFrm.Show();
            this.Hide();
        }
        /// <summary>
        /// Logout 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        /// <summary>
        /// Go to SELLERS View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label10_Click(object sender, EventArgs e)
        {
            new SellerForm().Show();
            this.Hide();
        }
    }
}
