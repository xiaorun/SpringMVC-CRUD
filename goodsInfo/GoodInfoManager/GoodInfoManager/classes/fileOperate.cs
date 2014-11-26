using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace GoodInfoManager.classes
{
    class FileOperate
    {
        private static string path = Environment.CurrentDirectory;
        private string filePathOfGood = path+"\\goods.dat";
        private string filePathOfSaler =path+"\\saler.dat";
        private string filePathOfStorer =path+ "\\storeManager.dat";

        /// <summary>
        /// 将信息写入文件
        /// </summary>
        /// <param name="ob">ob是要写入文件的序列对象,List GoodInfo或者List SalerInfo 或者List storeManager</param>
        /// <param name="flag">1代表商品，2代表销售人员，3代表库存管理员</param>
        /// <returns></returns>
        public bool writeInfo(object ob,int flag)
        {
            try
            {
                if(flag==1)
                {
                    Serialize(ob,filePathOfGood);
                }
                else if(flag==2)
                {
                    Serialize(ob,filePathOfSaler);
                }
                else if(flag==3)
                {
                    Serialize(ob, filePathOfStorer);
                }else
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                
            }
        }
        /// <summary>
        /// 读取信息
        /// </summary>
        /// <param name="flag">1代表商品，2代表销售人员，3代表库存管理员</param>
        /// <returns></returns>
        public object readInfo(int flag)
        {
            if (flag == 1)
            {
                return Deserialize(filePathOfGood);
            }
            else if (flag == 2)
            {
                return Deserialize(filePathOfSaler);
            }
            else if (flag == 3)
            {
                return Deserialize(filePathOfStorer);
            }
            else
            {
                return null;
            }
        }
        private void Serialize(object ob, string filePath)//序列化
        {
            BinaryFormatter transfer = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            transfer.Serialize(ms,ob);
            byte[] b = new byte[ms.Length];
            b = ms.GetBuffer();
            FileStream fs = File.Create(filePath);
            fs.Write(b, 0, b.Length);//以覆盖的形式写入
            ms.Close(); fs.Close();
        }
        private object Deserialize(string filePath)//反序列化
        {
            FileStream fs = File.OpenRead(filePath);
            byte[] b = new byte[fs.Length];
            fs.Read(b, 0, b.Length);
            fs.Close();
            BinaryFormatter transfer = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(b);
            object ob= (object)transfer.Deserialize(ms);
            ms.Close();
            return ob; 
        }
    }
}
