namespace 李荣武
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyGridView = new System.Windows.Forms.DataGridView();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.选修课成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.试验课成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.必修课成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.信息维护ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2127, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(82, 38);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 信息维护ToolStripMenuItem
            // 
            this.信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.录入学生信息ToolStripMenuItem,
            this.删除学生信息ToolStripMenuItem,
            this.修改学生信息ToolStripMenuItem,
            this.查看学生信息ToolStripMenuItem});
            this.信息维护ToolStripMenuItem.Name = "信息维护ToolStripMenuItem";
            this.信息维护ToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.信息维护ToolStripMenuItem.Text = "信息维护";
            // 
            // 录入学生信息ToolStripMenuItem
            // 
            this.录入学生信息ToolStripMenuItem.Name = "录入学生信息ToolStripMenuItem";
            this.录入学生信息ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.录入学生信息ToolStripMenuItem.Text = "录入学生信息";
            this.录入学生信息ToolStripMenuItem.Click += new System.EventHandler(this.录入学生信息ToolStripMenuItem_Click);
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            this.删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            this.删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.删除学生信息ToolStripMenuItem.Text = "删除学生信息";
            this.删除学生信息ToolStripMenuItem.Click += new System.EventHandler(this.删除学生信息ToolStripMenuItem_Click);
            // 
            // 修改学生信息ToolStripMenuItem
            // 
            this.修改学生信息ToolStripMenuItem.Name = "修改学生信息ToolStripMenuItem";
            this.修改学生信息ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.修改学生信息ToolStripMenuItem.Text = "修改学生信息";
            this.修改学生信息ToolStripMenuItem.Click += new System.EventHandler(this.修改学生信息ToolStripMenuItem_Click);
            // 
            // 查看学生信息ToolStripMenuItem
            // 
            this.查看学生信息ToolStripMenuItem.Name = "查看学生信息ToolStripMenuItem";
            this.查看学生信息ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.查看学生信息ToolStripMenuItem.Text = "查看学生信息";
            this.查看学生信息ToolStripMenuItem.Click += new System.EventHandler(this.查看学生信息ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(82, 38);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(212, 44);
            this.关于AToolStripMenuItem.Text = "关于A";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // MyGridView
            // 
            this.MyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号,
            this.姓名,
            this.选修课成绩,
            this.试验课成绩,
            this.必修课成绩,
            this.总分});
            this.MyGridView.Location = new System.Drawing.Point(0, 85);
            this.MyGridView.Margin = new System.Windows.Forms.Padding(4);
            this.MyGridView.Name = "MyGridView";
            this.MyGridView.RowHeadersWidth = 82;
            this.MyGridView.RowTemplate.Height = 37;
            this.MyGridView.Size = new System.Drawing.Size(2127, 1013);
            this.MyGridView.TabIndex = 1;
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
            // 试验课成绩
            // 
            this.试验课成绩.HeaderText = "试验课成绩";
            this.试验课成绩.MinimumWidth = 10;
            this.试验课成绩.Name = "试验课成绩";
            this.试验课成绩.Width = 200;
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
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1102);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2127, 41);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(155, 31);
            this.toolStripStatusLabel1.Text = "学生人数： 6";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 42);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(2127, 42);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 36);
            this.toolStripButton1.Text = "录入学生信息";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(46, 36);
            this.toolStripButton2.Text = "删除学生信息";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(46, 36);
            this.toolStripButton3.Text = "修改学生信息";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(46, 36);
            this.toolStripButton4.Text = "查看学生信息";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2127, 1143);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MyGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理系统_202178010109_李荣武";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 录入学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.DataGridView MyGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 选修课成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 试验课成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 必修课成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总分;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
    }
}

