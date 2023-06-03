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
    public partial class FormSet : Form
    {

        private TextBox textBox1 = new TextBox();
        private TextBox textBox2 = new TextBox();

        private NumericUpDown numericUpDown1 = new NumericUpDown();
        private NumericUpDown numericUpDown2 = new NumericUpDown();
        private NumericUpDown numericUpDown3 = new NumericUpDown();


        private string MyConnStr;
        private Action QueryData;

        public FormSet(string myConnStr, Action queryData, Score newScore)
        {
            MyConnStr = myConnStr;
            QueryData = queryData;

            InitializeComponent();

            //实例化一个命令按钮
            Button btn = new Button();
            //设置命令按钮的属性
            btn.Location = new Point(220, 550);
            btn.Size = new Size(150, 55);
            btn.Text = "修改";
            btn.Click += btn_Click;
            //添加到窗口的Controls集合中
            this.Controls.Add(btn);


            // 学号
            Label lbl = new Label();
            lbl.Location = new Point(50, 50);
            lbl.Size = new Size(150, 55);
            lbl.Text = "学      号:";
            this.Controls.Add(lbl);

            textBox1.Location = new Point(220, 50);
            textBox1.Size = new Size(200, 55);
            textBox1.Text = newScore.XueHao;
            this.Controls.Add(textBox1);


            // 姓名
            Label lb2 = new Label();
            lb2.Location = new Point(50, 150);
            lb2.Size = new Size(150, 55);
            lb2.Text = "姓      名:";
            this.Controls.Add(lb2);

            textBox2.Location = new Point(220, 150);
            textBox2.Size = new Size(200, 55);
            textBox2.Text = newScore.XinMin;
            this.Controls.Add(textBox2);


            // 选修课成绩
            Label lb3 = new Label();
            lb3.Location = new Point(50, 250);
            lb3.Size = new Size(150, 55);
            lb3.Text = "选修课成绩:";
            this.Controls.Add(lb3);

            numericUpDown1.Location = new Point(220, 250);
            numericUpDown1.Size = new Size(200, 55);
            numericUpDown1.Value = 100;
            numericUpDown1.Value = newScore.XuanXiuKe;
            this.Controls.Add(numericUpDown1);


            // 实验课成绩
            Label lb4 = new Label();
            lb4.Location = new Point(50, 350);
            lb4.Size = new Size(150, 55);
            lb4.Text = "实验课成绩:";
            this.Controls.Add(lb4);


            numericUpDown2.Location = new Point(220, 350);
            numericUpDown2.Size = new Size(200, 55);
            numericUpDown2.Value = 100;
            numericUpDown2.Value= newScore.SiYanKe;
            this.Controls.Add(numericUpDown2);


            // 必修课课成绩
            Label lb5 = new Label();
            lb5.Location = new Point(50, 450);
            lb5.Size = new Size(150, 55);
            lb5.Text = "必修课成绩:";
            this.Controls.Add(lb5);

            numericUpDown3.Location = new Point(220, 450);
            numericUpDown3.Size = new Size(200, 55);
            numericUpDown3.Value = 100;
            numericUpDown3.Value= newScore.BiXueKe;
            this.Controls.Add(numericUpDown3);


        }

        private void InitializeComponent()
        {
            //设定按字体来缩放控件  
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //设定字体大小为12px       
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
        }

        // 确认添加
        void btn_Click(object sender, EventArgs e)
        {

            string XueHaoStr = textBox1.Text;
            string XingMingStr = textBox2.Text;
            decimal XuanXiuKeD = numericUpDown1.Value;
            decimal ShiYanKeD = numericUpDown2.Value;
            decimal BiXiuKeD = numericUpDown3.Value;
            decimal ZongFenD = XuanXiuKeD + ShiYanKeD + BiXiuKeD;
            if (XueHaoStr != "&nbsp:" && XueHaoStr != "")
            {
                string MySelectQuery = "SELECT * FROM 学生信息表 WHERE 学号 = '" + XueHaoStr + "'";
                OleDbConnection MyConn = new OleDbConnection(MyConnStr);
                OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySelectQuery, MyConnStr);
                DataSet MyDataSet = new DataSet();
                OleDbCommandBuilder MyCommandBuilder = new OleDbCommandBuilder(MyAdapter);
                MyConn.Open();
                MyAdapter.Fill(MyDataSet, "学生信息表");
                if (MyDataSet.Tables["学生信息表"].Rows.Count == 1)
                {
                    try
                    {
                        MySelectQuery = "UPDATE 学生信息表 SET " + " 学号 = '" + XueHaoStr + "',姓名 = '" + XingMingStr + "',选修课成绩 = '" + XuanXiuKeD +
                            "', 实验课成绩 = '" + ShiYanKeD + "', 必修课成绩 = '" + BiXiuKeD + "',总分 = '" + ZongFenD + "' WHERE 学号 = '" + XueHaoStr + "'";
                        OleDbDataAdapter MyAdapterl = new OleDbDataAdapter(MySelectQuery, MyConnStr);
                        DataSet MyDataSetl = new DataSet();
                        MyAdapterl.Fill(MyDataSetl, "学生信息表");
                        MyDataSetl = null;
                        MyAdapterl = null;
                        // 删除成功刷新
                        this.QueryData();

                        MessageBox.Show("参数修改成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.Close();
                    }
                    catch (OleDbException Err)
                    {
                        if ((Err.ErrorCode == -2147467259) || (Err.ErrorCode == -2147217843) || (Err.ErrorCode == -2147217865))
                        {
                            MessageBox.Show("数据库访问异常，修改失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("此记录不存在，修改失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                MyDataSet = null;
                MyAdapter = null;
                MyConn.Close();
                MyConn = null;
            }
            else
            {
                MessageBox.Show("学号不能为空，修改失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}