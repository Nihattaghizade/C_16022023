using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _16022023home
{
    internal class Store
    {
        
        int maxPercent = Products[0];
        public Product[] Products = new Product[0];

        public int DairyProductCountLimit()
        {
            int count = 0;

            foreach (var item in Products)
            {
                if (item is Dairy)
                    count++;
            }
            return count;
        }
        
        public double AlcoholPercentLimit()
        {
            double alchocolPercent = 0;

            foreach (var item in Products)
            {
                if(item is Drink)
                
                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i] > maxPercent)
                        maxPercent = Products[i];
                }

                
            }
            return maxPercent;
        }

        public void AddProduct(Product Products);

        public static bool HasProductByNo(this string No)
        {

        }

        public void GetDrinkProducts();

        public void GetDrinkProducts();

    }
}
