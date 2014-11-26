using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodInfoManager.classes;

namespace GoodInfoManager.GoodInfoForm
{
    public partial class updateGood : Form
    {
        public updateGood()
        {
            InitializeComponent();
        }
        private FileOperate fo = new FileOperate();
        private List<GoodInfo> goods = new List<GoodInfo> { };
        private int goodID;
        private int updateFlag = 0;
        private void findById(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入商品编号");
                return;
            }
            goodID=int.Parse(textBox1.Text);
            loadData();
        }
        private void txtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入           
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void loadData()
        {
            int flag = 0;
            goods =(List<GoodInfo>) fo.readInfo(1);
            for(int i=0;i<goods.Count;i++)
            {
                if(goodID==goods[i].Id)
                {
                    name.Text = goods[i].Name;
                    price.Text = goods[i].Price.ToString();
                    store.Text = goods[i].StoreNum.ToString();
                    manufacturer.Text = goods[i].Manufacturer;
                    flag = 1;
                    break;
                }               
            }
            if (flag==0)
            {
                controlClear();
                MessageBox.Show("没有查到该商品");
            }
            else
            {
                updateFlag = 1;
            }
        }
        private void controlClear()
        {
            foreach(Control ctl in groupBox2.Controls)
            {
                if(ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
        }

        private void update(object sender, EventArgs e)
        {
            if(updateFlag!=1)
            {
                MessageBox.Show("请先验证信息");
                return;
            }
            for (int i = 0; i < goods.Count; i++)
            {
                if (goodID == goods[i].Id)
                {
                     goods[i].Name=name.Text;
                    goods[i].Price=float.Parse(price.Text );
                    goods[i].StoreNum=int.Parse(store.Text);
                    goods[i].Manufacturer=manufacturer.Text;
                    break;
                }
            }
            bool b=  fo.writeInfo(goods,1);
            if(b==true)
            {
                MessageBox.Show("信息更新成功");
                controlClear();
            }
        }
    }
}
