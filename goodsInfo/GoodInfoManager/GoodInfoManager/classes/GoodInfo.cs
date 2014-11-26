using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodInfoManager.classes
{
     [Serializable]
    public class GoodInfo
    {
        private int id;
        private string name;
        private float price;
        private int storeNum;
        string manufacturer;
        public int Id//调用方法.+大写属性名调用get或set方法，C#规则
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        
        public int StoreNum
        {
            get { return storeNum; }
            set { storeNum = value; }
        }
        
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        } 
        public GoodInfo(int id,string name,float price,int storeNum,string manufacturer)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.storeNum = storeNum;
            this.manufacturer = manufacturer;
        }
    }
}
