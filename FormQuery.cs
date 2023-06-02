using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 李荣武
{
    internal class FormQuery:Form
    {

        private string MyConnStr;


        private DataGridView MyGridView = new DataGridView();
        private DataGridViewTextBoxColumn 学号 = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn 姓名 = new  DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn 选修课成绩 = new  DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn 实验课成绩 = new  DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn 必修课成绩 = new  DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn 总分 = new  DataGridViewTextBoxColumn();

        private Label label1=new Label();
        private Label label2=new Label();

        private TextBox TextBox1=new TextBox();
        private TextBox TextBox2=new TextBox();

        private Button btn = new Button();

        public FormQuery(string myConnStr) 
        {
            MyConnStr =myConnStr;


            MyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            学号,
            姓名,
            选修课成绩,
            实验课成绩,
            必修课成绩,
            总分});
            MyGridView.Name = "MyGridView2";
            MyGridView.Location = new Point(0, 80);
            MyGridView.Size = new Size(1500, 650);
            MyGridView.ColumnHeadersHeight = 50;
            MyGridView.TabIndex = 0;
            this.Controls.Add(MyGridView);


            // 
            // 学号
            // 
            this.学号.HeaderText = "学号";
            this.学号.MinimumWidth = 10;
            this.学号.Name = "学号";
            this.学号.Width = 200;
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.MinimumWidth = 10;
            this.姓名.Name = "姓名";
            this.姓名.Width = 200;
            // 
            // 选修课成绩
            // 
            this.选修课成绩.HeaderText = "选修课成绩";
            this.选修课成绩.MinimumWidth = 10;
            this.选修课成绩.Name = "选修课成绩";
            this.选修课成绩.Width = 200;
            // 
            // 实验课成绩
            // 
            this.实验课成绩.HeaderText = "实验课成绩";
            this.实验课成绩.MinimumWidth = 10;
            this.实验课成绩.Name = "实验课成绩";
            this.实验课成绩.Width = 200;
            // 
            // 必修课成绩
            // 
            this.必修课成绩.HeaderText = "必修课成绩";
            this.必修课成绩.MinimumWidth = 10;
            this.必修课成绩.Name = "必修课成绩";
            this.必修课成绩.Width = 200;
            // 
            // 总分
            // 
            this.总分.HeaderText = "总分";
            this.总分.MinimumWidth = 10;
            this.总分.Name = "总分";
            this.总分.Width = 200;


            // 学号
            label1.Location = new Point(200,30);
            label1.Size = new Size(100,40);
            label1.Text = "学 号: ";
            this.Controls.Add(label1);

            TextBox1.Location = new Point(300, 25);
            TextBox1.Size = new Size(220, 50);
            this.Controls.Add(TextBox1);

            // 姓名
            label2.Location = new Point(600, 30);
            label2.Size = new Size(100, 40);
            label2.Text = "姓 名: ";
            this.Controls.Add(label2);

            TextBox2.Location = new Point(700, 25);
            TextBox2.Size = new Size(220, 50);
            this.Controls.Add(TextBox2);

            // 查询
            btn.Location = new Point(950, 10);
            btn.Size = new Size(150, 60);
            btn.Text = "查询";
            btn.Click += btn_Click;
            this.Controls.Add(btn);


        }

        // 查询方法
        void btn_Click(object sender, EventArgs e)
        {
            string XueHaoStr = TextBox1.Text.Trim();
            string XingMingStr = TextBox2.Text.Trim();


            string MySelectQuery = "SELECT * FROM 学生信息表 ";
            if (XueHaoStr != "" || XingMingStr != "")
            {
                MySelectQuery += " WHERE ";
            }
            if (XueHaoStr != "")
            {
                MySelectQuery += "学号 LIKE '%" + XueHaoStr + "%'";
            }
            if (XingMingStr != "")
            {
                if (XueHaoStr != "")
                {
                    MySelectQuery += "AND 姓名 LIKE '%" + XingMingStr + "%'";
                }
                else
                {
                    MySelectQuery += "姓名 LIKE '%" + XingMingStr + "%'";
                }
            }
            MySelectQuery = MySelectQuery + " ORDER BY 学号 ASC";
            OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySelectQuery, MyConnStr);
            DataSet MyDataSet = new DataSet();
            MyAdapter.Fill(MyDataSet, "学生信息表");
            MyGridView.Rows.Clear();
            foreach (DataRow therow in MyDataSet.Tables["学生信息表"].Rows)
            {
                MyGridView.Rows.Add(therow["学号"], therow["姓名"], therow["选修课成绩"],
                    therow["实验课成绩"], therow["必修课成绩"], therow["总分"]);
            }
            MyDataSet = null;
            MyAdapter = null;
        }
    }
}
