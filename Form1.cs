using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 李荣武
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
            QueryData();
        }

        private string FilePath
        {
            get
            {
                return System.AppDomain.CurrentDomain.BaseDirectory + "Student.mdb";
            }
        }

        private string MyConnStr
        {
            get
            {
                return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.FilePath + ";Jet OLEDB:Database Password=";
            }
        }


        // 退出程序
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DialogResult dr =  MessageBox.Show("确认退出","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Dispose(true);
            }
        }

        // 帮助
        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("软件仅供学习", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }




        // 刷新方法
        private void QueryData()
        {

            string MySelectQuery = "SELECT * FROM 学生信息表 ";

            MySelectQuery = MySelectQuery + "ORDER BY 学号 ASC";
            OleDbDataAdapter MyAdapter = new OleDbDataAdapter(MySelectQuery, this.MyConnStr);
            DataSet MyDataSet = new DataSet();
            MyAdapter.Fill(MyDataSet, "学生信息表");
            MyGridView.Rows.Clear();

            // 学生人数
            toolStripStatusLabel1.Text = "学生人数: " + MyDataSet.Tables["学生信息表"].Rows.Count;

            foreach (DataRow therow in MyDataSet.Tables["学生信息表"].Rows)
            {
                MyGridView.Rows.Add(therow["学号"], therow["姓名"], therow["选修课成绩"], therow["实验课成绩"], therow["必修课成绩"], therow["总分"]);
            }
            MyDataSet = null;
            MyAdapter = null; ;
        }


        // 创建查询窗体
        private void createQuery()
        {
            FormQuery formQuery = new FormQuery(this.MyConnStr);
            formQuery.Text = "查找学生信息";
            formQuery.StartPosition = FormStartPosition.CenterScreen;
            formQuery.Size = new Size(1500, 800);
            formQuery.ShowDialog();
        }


        // 图片框查询信息
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.createQuery();
        }

        // 选项框查询信息
        private void 查看学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.createQuery();
        }

        
        // 创建添加窗口
        private void createAdd()
        {
            FormAdd fAdd = new FormAdd(MyConnStr,this.QueryData);
            fAdd.Text = "录入信息";
            fAdd.StartPosition = FormStartPosition.CenterScreen;
            fAdd.Size = new Size(600, 700);
            fAdd.ShowDialog();
        }


        // 图片框录入学生信息
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.createAdd();
        }

        // 选项框录入学生信息
        private void 录入学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.createAdd();
        }

        // 删除记录
        private void deleteData()
        {
            if (MyGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("不支持多行删除！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (MyGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的行！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (MyGridView.SelectedRows[0].Cells["学号"].Value == null)
            {
                MessageBox.Show("请选择有学号的行！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            DialogResult dr = MessageBox.Show("确认删除！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

            }
            else
            {
                MessageBox.Show("取消删除！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            string XueHaoStr = MyGridView.SelectedRows[0].Cells["学号"].Value.ToString();
            if (XueHaoStr != "")
            {
                string FilePath = System.AppDomain.CurrentDomain.BaseDirectory + "Student.mdb";
                string MyConnStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + FilePath + ";Jet oledb:database password=";
                string MySelectQuery = "";
                MySelectQuery = "SELECT * FROM 学生信息表 WHERE 学号 = '" + XueHaoStr + "'";
                try
                {
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
                            MySelectQuery = "DELETE FROM 学生信息表 WHERE 学号 = '" + XueHaoStr + "'";
                            OleDbDataAdapter MyAdapter1 = new OleDbDataAdapter(MySelectQuery, MyConnStr);
                            DataSet MyDataSet1 = new DataSet();
                            MyAdapter1.Fill(MyDataSet1, "学生信息表");
                            MyAdapter1 = null;
                            MyDataSet1 = null;
                            // 删除成功刷新
                            this.QueryData();
                            MessageBox.Show("删除成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        catch (OleDbException Err)
                        {
                            if ((Err.ErrorCode == -2147467259) || (Err.ErrorCode == -2147217843) || (Err.ErrorCode == -2147217865))
                            {
                                MessageBox.Show("数据库访问失败，删除失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("此记录不存在,修改失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    MyAdapter = null;
                    MyDataSet = null;
                }
                catch (OleDbException Err)
                {
                    if ((Err.ErrorCode == -2147467259) || (Err.ErrorCode == -2147217843) || (Err.ErrorCode == -2147217865))
                    {
                        MessageBox.Show("数据库访问失败，删除失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            else
            {
                MessageBox.Show("学号不能为空，修改失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        // 图片框删除记录
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.deleteData();
        }

        // 选项框删除数据
        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.deleteData();
        }


        // 创建修改窗体
        private void createSet()
        {
            if (MyGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("不支持多行修改！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (MyGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要修改的行！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (MyGridView.SelectedRows[0].Cells["学号"].Value == null)
            {
                MessageBox.Show("请选择有学号的行！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }


            // 学生成绩对象
             Score newScore = new Score(
                 (string)MyGridView.SelectedRows[0].Cells["学号"].Value,
                 (string)MyGridView.SelectedRows[0].Cells["姓名"].Value,
                 MyGridView.SelectedRows[0].Cells["选修课成绩"].Value+"",
                 MyGridView.SelectedRows[0].Cells["试验课成绩"].Value+"",
                 MyGridView.SelectedRows[0].Cells["必修课成绩"].Value+""
                 );

            FormSet fSet = new FormSet(MyConnStr, this.QueryData,newScore);
            fSet.Text = "修改信息";
            fSet.StartPosition = FormStartPosition.CenterScreen;
            fSet.Size = new Size(600, 700);
            fSet.ShowDialog();
        }

        // 图片框修改
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            createSet();
        }

        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createSet();
        }
    }
}
