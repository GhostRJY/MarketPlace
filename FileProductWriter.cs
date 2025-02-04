using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    //запись продукта в файл (руководствуюсь Single Resposibility Principe)
    static class FileProductWriter
    {
        static int m_productCount = 0;
        public static int ProductCount { get { return m_productCount; } }

        static public void WriteProductToFile(in IProduct product)
        {
            ++m_productCount;
            var path = m_productCount + ".txt";
            var fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            byte[] bytes = Encoding.UTF8.GetBytes(product.ToString());

            fs.Write(bytes, 0, bytes.Length);
            fs.Flush();
            fs.Close();
        }

        static public void WriteAllProductsToFile(in List<IProduct> product)
        {            
            var path = "AllElementsOfMarket.txt";
            var fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            foreach(var element in product)
            {
                ++m_productCount;
                byte[] bytes = Encoding.UTF8.GetBytes(element.ToString());
                fs.Write(bytes, 0, bytes.Length);
            }

            fs.Flush();
            fs.Close();
        }
    }
}
