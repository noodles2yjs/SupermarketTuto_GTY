using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SupermarketTuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string SellerName = "";

        private void label4_Click(object sender, EventArgs e)
        {
            unameTb.Text = "";
            upassTb.Text = "";
        }

        public SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=smarketdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        /// <summary>
        /// login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (unameTb.Text == "" || upassTb.Text == "null")
            {
                MessageBox.Show("Enter Username and Password");
            }

            else
            {
                if (roleCb.SelectedIndex >-1)
                {
                    {
                        if (roleCb.SelectedItem.ToString() == "Admin")
                        {
                            if (unameTb.Text == "Admin" && upassTb.Text == "Admin")
                            {
                                ProductForm productForm = new ProductForm();
                                productForm.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("If you are the Admin,Enter the correct Id and Password");
                            }
                        }
                       
                        else
                        {
                            // MessageBox.Show("You in the Seller Selection");
                            Con.Open();
                             string query = $" select count(0) from SellerTbl where SellerName ='{unameTb.Text}' and SellerPass ='{upassTb.Text}'";
                            DataTable table = new DataTable();
                            new SqlDataAdapter(query, Con).Fill(table);
                            if (table.Rows[0][0].ToString() != "1")
                            {
                                MessageBox.Show("Wrong UserName or Password!");
                            }
                            else
                            {
                                SellerName = unameTb.Text;
                                this.Hide();
                                new SellingForm().Show();
                                Con.Close();
                            }


                            Con.Close();

                        }

                    }
                }

                else
                {
                    MessageBox.Show("Select a Role");
                }
            }

        }
    }
}
