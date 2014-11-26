using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodInfoManager.SalePersonForm;
using GoodInfoManager.StorePersonForm;
using GoodInfoManager.GoodInfoForm;

namespace GoodInfoManager
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private int buttonFlag = -1;//子菜单的名字有重复，创建菜单时记录状态
        void ButtonClick(object sender, EventArgs e)
        {
            // Get the clicked button...
            Button clickedButton = (Button)sender;
            // ... and it's tabindex
            int clickedButtonTabIndex = clickedButton.TabIndex;

            // Send each button to top or bottom as appropriate
            foreach (Control ctl in panel3.Controls)
            {
                if (ctl is Button)
                {
                    Button btn = (Button)ctl;
                    if (btn.TabIndex > clickedButtonTabIndex)
                    {
                        if (btn.Dock != DockStyle.Bottom)
                        {
                            btn.Dock = DockStyle.Bottom;
                            // This is vital to preserve the correct order
                            btn.BringToFront();
                        }
                    }
                    else
                    {
                        if (btn.Dock != DockStyle.Top)
                        {
                            btn.Dock = DockStyle.Top;
                            // This is vital to preserve the correct order
                            btn.BringToFront();
                        }
                    }
                }
            }

            // Determine which button was clicked.
            switch (clickedButton.Text)
            {
                case "售货员":
                    creatSalePersonList();
                    break;

                case "库存管理员":
                    creatStorePersonList();
                    break;

                case "商品信息":
                    creatGoodList();
                    break;
            }
            listView1.BringToFront();  // Without this, the buttons will hide the items.
        }//遍历所有Button加载菜单
        private void creatSalePersonList()
        {
            listView1.Items.Clear();
            listView1.LargeImageList = SalePerson;
            listView1.Items.Add("添加员工");
            listView1.Items.Add("查看信息");
            buttonFlag = 1;
        }//创建售货员菜单
        private void creatStorePersonList()
        {
            listView1.Items.Clear();
            listView1.LargeImageList =Storer;
            listView1.Items.Add("添加员工");
            listView1.Items.Add("查看信息");
            buttonFlag = 2;
        }//创建库存管理员菜单
        private void creatGoodList()
        {
            listView1.Items.Clear();
            listView1.LargeImageList = goodInfo;
            listView1.Items.Add("添加商品");
            listView1.Items.Add("查看商品");
            listView1.Items.Add("更新信息");
            buttonFlag = 3;
        }//创建商品信息菜单

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x=30;//新窗口的横坐标
            int y=30;//新窗口的纵坐标
            if(this.listView1.SelectedIndices.Count>0)
            {
                if(this.listView1.SelectedItems[0].Text=="添加员工" &&buttonFlag==1)
                {
                    AddFormToPanel2(new addSalePerson(), splitContainer1.Panel2.ClientSize, x, y);
                }
                else if (this.listView1.SelectedItems[0].Text == "查看信息" && buttonFlag == 1)
                {
                    AddFormToPanel2(new LookSaleSalary(), splitContainer1.Panel2.ClientSize, x, y);
                }else if(this.listView1.SelectedItems[0].Text=="添加员工" &&buttonFlag==2)
                {
                    AddFormToPanel2(new addStorePerson(), splitContainer1.Panel2.ClientSize, x, y);
                }
                else if (this.listView1.SelectedItems[0].Text == "查看信息" && buttonFlag == 2)
                {
                    AddFormToPanel2(new lookStoreSalary(), splitContainer1.Panel2.ClientSize, x, y);
                }else if(this.listView1.SelectedItems[0].Text == "添加商品")
                {
                    AddFormToPanel2(new addGood(), splitContainer1.Panel2.ClientSize, x, y);
                }
                else if (this.listView1.SelectedItems[0].Text == "查看商品")
                {
                    AddFormToPanel2(new lookGood(), splitContainer1.Panel2.ClientSize, x, y);
                }
                else if (this.listView1.SelectedItems[0].Text == "更新信息")
                {
                    AddFormToPanel2(new updateGood(), splitContainer1.Panel2.ClientSize, x, y);
                }
            }
        }
        public void AddFormToPanel2(Form form, Size s, int x, int y)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            form.MdiParent = this;
            form.Parent = this.splitContainer1.Panel2;
            form.Location = new Point(10 + x, 3 + y);
            form.Show();
            form.Size = s;
        }//动态加载Form窗体


        private void Exsit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                // e.Cancel = true; //取消关闭操作
            }
            else Application.Exit();
        }
    }
}
