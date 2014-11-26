namespace GoodInfoManager
{
    partial class main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SelfInfo = new System.Windows.Forms.Button();
            this.StuInfo = new System.Windows.Forms.Button();
            this.CourseInfo = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SalePerson = new System.Windows.Forms.ImageList(this.components);
            this.Storer = new System.Windows.Forms.ImageList(this.components);
            this.goodInfo = new System.Windows.Forms.ImageList(this.components);
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Location = new System.Drawing.Point(-5, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(837, 619);
            this.panel4.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 82);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(284, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 69);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(361, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售管理系统";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.SelfInfo);
            this.panel3.Controls.Add(this.StuInfo);
            this.panel3.Controls.Add(this.CourseInfo);
            this.panel3.Location = new System.Drawing.Point(2, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 518);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Location = new System.Drawing.Point(174, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(658, 536);
            this.panel5.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Menu;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(0, 136);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(176, 382);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(0, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "退出系统";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Exsit);
            // 
            // SelfInfo
            // 
            this.SelfInfo.AllowDrop = true;
            this.SelfInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SelfInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelfInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelfInfo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelfInfo.ForeColor = System.Drawing.Color.Blue;
            this.SelfInfo.Location = new System.Drawing.Point(0, 68);
            this.SelfInfo.Name = "SelfInfo";
            this.SelfInfo.Size = new System.Drawing.Size(176, 34);
            this.SelfInfo.TabIndex = 5;
            this.SelfInfo.Text = "商品信息";
            this.SelfInfo.UseVisualStyleBackColor = false;
            this.SelfInfo.Click += new System.EventHandler(this.ButtonClick);
            // 
            // StuInfo
            // 
            this.StuInfo.AllowDrop = true;
            this.StuInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.StuInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.StuInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StuInfo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuInfo.ForeColor = System.Drawing.Color.Blue;
            this.StuInfo.Location = new System.Drawing.Point(0, 34);
            this.StuInfo.Name = "StuInfo";
            this.StuInfo.Size = new System.Drawing.Size(176, 34);
            this.StuInfo.TabIndex = 4;
            this.StuInfo.Text = "库存管理员";
            this.StuInfo.UseVisualStyleBackColor = false;
            this.StuInfo.Click += new System.EventHandler(this.ButtonClick);
            // 
            // CourseInfo
            // 
            this.CourseInfo.AllowDrop = true;
            this.CourseInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CourseInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CourseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseInfo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CourseInfo.ForeColor = System.Drawing.Color.Blue;
            this.CourseInfo.Location = new System.Drawing.Point(0, 0);
            this.CourseInfo.Name = "CourseInfo";
            this.CourseInfo.Size = new System.Drawing.Size(176, 34);
            this.CourseInfo.TabIndex = 3;
            this.CourseInfo.Text = "售货员";
            this.CourseInfo.UseVisualStyleBackColor = false;
            this.CourseInfo.Click += new System.EventHandler(this.ButtonClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 82);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(837, 537);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 5;
            // 
            // SalePerson
            // 
            this.SalePerson.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SalePerson.ImageStream")));
            this.SalePerson.TransparentColor = System.Drawing.Color.Transparent;
            this.SalePerson.Images.SetKeyName(0, "js1.png");
            this.SalePerson.Images.SetKeyName(1, "js2.png");
            this.SalePerson.Images.SetKeyName(2, "JS3.png");
            this.SalePerson.Images.SetKeyName(3, "35054.png");
            this.SalePerson.Images.SetKeyName(4, "350541.png");
            // 
            // Storer
            // 
            this.Storer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Storer.ImageStream")));
            this.Storer.TransparentColor = System.Drawing.Color.Transparent;
            this.Storer.Images.SetKeyName(0, "js2.png");
            this.Storer.Images.SetKeyName(1, "js1.png");
            this.Storer.Images.SetKeyName(2, "apps.ico");
            this.Storer.Images.SetKeyName(3, "play_stop.ico");
            // 
            // goodInfo
            // 
            this.goodInfo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("goodInfo.ImageStream")));
            this.goodInfo.TransparentColor = System.Drawing.Color.Transparent;
            this.goodInfo.Images.SetKeyName(0, "头像.png");
            this.goodInfo.Images.SetKeyName(1, "yaoshi.png");
            this.goodInfo.Images.SetKeyName(2, "1223.png");
            this.goodInfo.Images.SetKeyName(3, "三角.png");
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 600);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员";
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SelfInfo;
        private System.Windows.Forms.Button StuInfo;
        private System.Windows.Forms.Button CourseInfo;
        private System.Windows.Forms.ImageList SalePerson;
        private System.Windows.Forms.ImageList Storer;
        private System.Windows.Forms.ImageList goodInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;

    }
}

