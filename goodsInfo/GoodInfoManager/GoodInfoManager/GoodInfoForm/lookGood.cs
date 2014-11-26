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
    public partial class lookGood : Form
    {
        public lookGood()
        {
            InitializeComponent();
        }
        private List<GoodInfo> goods = new List<GoodInfo> { };
        FileOperate fo = new FileOperate();
        private void lookGood_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            goods = (List<GoodInfo>)fo.readInfo(1);

            for (int i = 0; i < goods.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = goods[i].Id;
                row.Cells[1].Value = goods[i].Name;
                row.Cells[2].Value = goods[i].Price;
                row.Cells[3].Value = goods[i].StoreNum;
                dataGridView1.Rows.Add(row);
            }
       }
    }
}
