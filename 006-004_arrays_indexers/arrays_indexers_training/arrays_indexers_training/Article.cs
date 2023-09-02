using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_indexers_training
{
    internal class Article
    {
        private string productName;
        private string shopName;
        private int priceInBYN;

        public Article(string productName, string shopName, int priceInBYN)
        {
            this.productName = productName;
            this.shopName = shopName;
            this.priceInBYN = priceInBYN;
        }
         
        public void displayInfo()
        {
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Shop Name: {shopName}");
            Console.WriteLine($"Product price in BYN: {priceInBYN}");
        }
        
        public string getProductName()
        { 
            return productName; 
        }
    }
}
