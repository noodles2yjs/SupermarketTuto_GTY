
namespace SupermarketTuto
{
    partial class HZHDGVTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucDataGridView1 = new HZH_Controls.Controls.UCDataGridView();
            this.ucPagerControl21 = new HZH_Controls.Controls.UCPagerControl2();
            this.SuspendLayout();
            // 
            // ucDataGridView1
            // 
            this.ucDataGridView1.BackColor = System.Drawing.Color.White;
            this.ucDataGridView1.Columns = null;
            this.ucDataGridView1.DataSource = null;
            this.ucDataGridView1.ForeColor = System.Drawing.Color.White;
            this.ucDataGridView1.HeadFont = new System.Drawing.Font("微软雅黑", 12F);
            this.ucDataGridView1.HeadHeight = 40;
            this.ucDataGridView1.HeadPadingLeft = 0;
            this.ucDataGridView1.HeadTextColor = System.Drawing.Color.Blue;
            this.ucDataGridView1.IsShowCheckBox = false;
            this.ucDataGridView1.IsShowHead = true;
            this.ucDataGridView1.Location = new System.Drawing.Point(320, 94);
            this.ucDataGridView1.Name = "ucDataGridView1";
            this.ucDataGridView1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.ucDataGridView1.RowHeight = 40;
            this.ucDataGridView1.RowType = typeof(HZH_Controls.Controls.UCDataGridViewRow);
            this.ucDataGridView1.Size = new System.Drawing.Size(685, 280);
            this.ucDataGridView1.TabIndex = 0;
            // 
            // ucPagerControl21
            // 
            this.ucPagerControl21.BackColor = System.Drawing.Color.White;
            this.ucPagerControl21.DataSource = null;
            this.ucPagerControl21.Location = new System.Drawing.Point(308, 416);
            this.ucPagerControl21.Name = "ucPagerControl21";
            this.ucPagerControl21.PageCount = 0;
            this.ucPagerControl21.PageIndex = 1;
            this.ucPagerControl21.PageModel = HZH_Controls.Controls.PageModel.Soure;
            this.ucPagerControl21.PageSize = 10;
            this.ucPagerControl21.Size = new System.Drawing.Size(697, 35);
            this.ucPagerControl21.StartIndex = 0;
            this.ucPagerControl21.TabIndex = 2;
            this.ucPagerControl21.ShowSourceChanged += new HZH_Controls.Controls.PageControlEventHandler(this.ucPagerControl21_ShowSourceChanged);
            this.ucPagerControl21.Load += new System.EventHandler(this.ucPagerControl21_Load);
            // 
            // HZHDGVTest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1108, 559);
            this.Controls.Add(this.ucPagerControl21);
            this.Controls.Add(this.ucDataGridView1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HZHDGVTest";
            this.Text = "HZHDGVTest";
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCDataGridView ucDataGridView1;
        private HZH_Controls.Controls.UCPagerControl2 ucPagerControl21;
    }
}