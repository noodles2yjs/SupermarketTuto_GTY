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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=smarketdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void populate()
        {
            Con.Open();
            String query = $"select ProdName,ProdPrice from ProductTbl where ProdCat ='{CatCb.SelectedValue}'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        /// <summary>
        /// Fill textVBox (Top left Area)
        /// </summary>
        private void fillTbox()
        {
            prodNameTb.Text = prodDgv.SelectedRows[0].Cells[0].Value.ToString();
            priceTb.Text = prodDgv.SelectedRows[0].Cells[1].Value.ToString();

        }


        private void fillCombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
            SqlDataReader sdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            //dt.Columns.Add("CatName", typeof(string));
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(sdr);
            CatCb.ValueMember = "catName";
            CatCb.DataSource = dt;
            Con.Close();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            dateLbl.Text = DateTime.Today.Date.ToString("yyyy/MM/dd");
            SellerNameLbl.Text = Form1.SellerName;
            populateBill();
           // fillTbox();
            fillCombo();
            populate();

        }
        /// <summary>
        /// Add product to Orderdgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        double Grdtotal = 0;int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (prodNameTb.Text=="" || qtyTb.Text=="")
            {
                MessageBox.Show("Missing Data", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                var total = Convert.ToDouble(priceTb.Text) * Convert.ToInt32(qtyTb.Text);
                DataGridViewRow viewRow = new DataGridViewRow();
                viewRow.CreateCells(orderDgv);
                viewRow.Cells[0].Value = n + 1;
                viewRow.Cells[1].Value = prodNameTb.Text;
                viewRow.Cells[2].Value = priceTb.Text;
                viewRow.Cells[3].Value = qtyTb.Text;
                viewRow.Cells[4].Value = (Convert.ToDouble(priceTb.Text) * Convert.ToInt32(qtyTb.Text)).ToString();
                Grdtotal += total;
                orderDgv.Rows.Add(viewRow);
                amtLbl.Text =  Grdtotal.ToString();
                n++;
            }

        }

      

        private void populateBill()
        {
            Con.Open();
            String query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sellsOrderListDgv.DataSource = ds.Tables[0];
            Con.Close();
        }

        /// <summary>
        /// Add Sells Button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            if (billIdTb.Text == "")
            {
                MessageBox.Show("BillId Missing", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = $"select count(0) from BillTbl where BillId ={billIdTb.Text}";
                    DataTable dataTable = new DataTable();
                    new SqlDataAdapter(query, Con).Fill(dataTable);
                    if (dataTable.Rows[0][0].ToString() =="1")
                    {
                        MessageBox.Show("The Bill ID is Already Exist.");
                        Con.Close();
                    }
                   

                    //  insert into ProductTbl values (ProdId,'ProdName','ProdQty','ProdCat')
                     query = $"insert into BillTbl values ('{billIdTb.Text}','{SellerNameLbl.Text}','{dateLbl.Text}','{amtLbl.Text}')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("BillOrder Add Sucessful!");
                    Con.Close();
                    populate();
                    populateBill();

                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                    MessageBox.Show("Add it Again");


                }
            }
        }

        /// <summary>
        /// sellsOrderListDgv bottom right 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sellsOrderListDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        /// <summary>
        /// 打印按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ChinaSun SuperMarket", new Font("宋体", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("BillId: " + sellsOrderListDgv.SelectedRows[0].Cells[0].Value.ToString(), new Font("宋体", 20, FontStyle.Bold), Brushes.Red, new Point(130, 150));
            e.Graphics.DrawString("Seller Name: " + sellsOrderListDgv.SelectedRows[0].Cells[1].Value.ToString(), new Font("宋体", 20, FontStyle.Bold), Brushes.Red, new Point(130, 180));
            e.Graphics.DrawString("Date " + sellsOrderListDgv.SelectedRows[0].Cells[2].Value.ToString(), new Font("宋体", 20, FontStyle.Bold), Brushes.Red, new Point(130, 210));
            e.Graphics.DrawString("Total Amount:  " + sellsOrderListDgv.SelectedRows[0].Cells[3].Value.ToString(), new Font("宋体", 20, FontStyle.Bold), Brushes.Red, new Point(130, 240));
            e.Graphics.DrawString("ChinaSun", new Font("宋体", 30, FontStyle.Bold), Brushes.Red, new Point(300, 300));

        }
        /// <summary>
        /// Reflesh Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = $"select ProdName,ProdPrice from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDgv.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            populate(); 
        }

        /// <summary>
        /// ProdDgv bottom left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        
        private void prodDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillTbox();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void orderDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
