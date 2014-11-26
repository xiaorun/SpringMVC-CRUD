using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodInfoManager.classes;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GoodInfoManager.GoodInfoForm
{
    public partial class addGood : Form
    {
        public addGood()
        {
            InitializeComponent();
        }
        GoodInfo good;
        List<GoodInfo> goods = new List<GoodInfo> { };
        FileOperate fo = new FileOperate();
        private void addGoodInfo(object sender, EventArgs e)//button添加事件
        {
            bool b = jude();
            if (b == false)
            {
                return;
            }
            bool b1 = add();
            if(b1==true)
            {
                MessageBox.Show("商品信息添加成功");
            }else
            {
                MessageBox.Show("商品信息添加失败");
            }
        }
        private bool add()
        {
            goods = (List<GoodInfo>)fo.readInfo(1);
            label4.Text = (goods.Count + 1).ToString();
            good = new GoodInfo(goods.Count + 1, name.Text, float.Parse(price.Text), int.Parse(store.Text), manufacturer.Text);
            goods.Add(good);
            bool b = fo.writeInfo(goods, 1);
            return b;
        }
        private bool jude()//判断商品信息填写格式是否正确
        {
            foreach(Control col in groupBox1.Controls )
            {
                if(col is TextBox)
                {
                    if(col.Text.Trim().Length==0)
                    {
                        MessageBox.Show("请将商品信息填写完整");
                        return false;
                    }
                }
            }
            return true;
        }
        private void txtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入           
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        } 
        private void addGood_Load(object sender, EventArgs e)
        {
            
        }
    }
}
