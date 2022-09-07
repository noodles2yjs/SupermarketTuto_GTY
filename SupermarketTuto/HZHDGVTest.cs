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
using HZH_Controls.Controls;
using SupermarketTuto.Model;

namespace SupermarketTuto
{
    public partial class HZHDGVTest : Form
    {
        public HZHDGVTest()
        {
            InitializeComponent();
            Load += HZHDGVTest_Load;
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
            ucDataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void populate2()
        {
            //Con.Open();
            //String query = "select * from ProductTbl";
            //SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            ////SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            ucDataGridView1.DataSource = null;

            //Con.Close();
        }
        private  int totalCont=0;
        /// <summary>
        /// 设置总条数
        /// </summary>
        private int SetTotalCount()
        {
            Con.Open();
            String query = "select count(0) from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            totalCont = (int) ds.Tables[0].Rows[0][0];
            Con.Close();
            return totalCont;
        }

        private DataSet SetDataSource()
        {
            Con.Open();
            String query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Con.Close();
            return ds;
        }
        private void HZHDGVTest_Load(object sender, EventArgs e)
        {
            List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Id", HeadText = "编号", Width = 70, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Name", HeadText = "学生姓名", Width = 30, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Age", HeadText = "年龄", Width = 70, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Birthday", HeadText = "出生日期", Width = 120, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Sex", HeadText = "性别", Width = 25, WidthType = SizeType.Percent });
            this.ucDataGridView1.Columns = lstCulumns;
            //populate();
           // SetTotalCount();

           this.ucDataGridView1.DataSource = this.ucPagerControl21.GetCurrentSource();
           this.ucDataGridView1.First();
        }

       
        private void ucPagerControl21_Load(object sender, EventArgs e)
        {
            totalCont = SetTotalCount();
            List<object> lstPage2 = new List<object>();
            for (int i = 0; i < 36; i++)
            {
                var student = new Student() {  Id = i, Age = i*2,Birthday = DateTime.Now.AddYears(-5),Name = "Mike"+i,Sex = "男"};
                lstPage2.Add(student);
            }

            ucPagerControl21.DataSource = lstPage2;

            ucPagerControl21.PageSize = 5;

            // ucPagerControl21.DataSource = lstPage2;
            // ucPagerControl21.PageCount = totalCont;

        }

        private void ucPagerControl21_ShowSourceChanged(object currentSource)
        {
            this.ucDataGridView1.DataSource = this.ucPagerControl21.GetCurrentSource();
        }
    }
}
