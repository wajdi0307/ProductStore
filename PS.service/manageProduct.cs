using PS.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PS.Service
{
    public class manageProduct
    {
        public Func<char, List<Product>> FindProduct;
        public Action<Category> ScanProduct;
        public manageProduct()
        {
            //FindProduct = Methode1;
            FindProduct = c =>
            {
                List<Product> ls2Product = new List<Product>();
                foreach (Product p in ls2Product)
                {
                    if (p.Name.StartsWith(c))
                    {
                        ls2Product.Add(p);
                    }
                }
                return ls2Product;

            };
            ScanProduct = cat =>
            {
                foreach(Product p  in lsProduct)
                {
                    if(p.Category.CategoryId == cat.CategoryId)
                    {
                        Console.WriteLine(p);
                    }
                }
            };
            }
    
       public  List<Product> lsProduct { get; set; }
        public List<Product> Methode1(char c)
        {
            List<Product> ls2Product = new List<Product>();
            foreach (Product p  in ls2Product)
            {
                if (p.Name.StartsWith("c"))
                {
                    ls2Product.Add(p);
                }
            }
            return ls2Product;
        }
        public IEnumerable<Chemical> getShemical(double price)
        {
            var req = from p in lsProduct.OfType<Chemical>()
                      where p.Price > price
                      select p;
            //return req.Take(5);
            //ignorer les 2 premiers produits 
            return req.Take(3);

        }
        public Double GetAveragePrice()
        {
            return lsProduct.Average(p => p.Price);
        }
        public Double GetMaxPrice()
        {
            return lsProduct.Max(p => p.Price);
        }
        public int GetCountProduct()
        {
            return lsProduct.OfType<Chemical>().Count();
        }
       public  IEnumerable<Chemical> GetShemicalCity(){
            /* var  req = from  c in lsProduct.OfType<Chemical>()
                      orderby c city .
            return req*/
            

            return lsProduct.OfType<Chemical>().OrderBy(prod => prod.City);

        }
        public IEnumerable< IGrouping<String,Chemical>>GetChemicalGroupByCity()
        {
           return lsProduct.OfType<Chemical>().GroupBy(prod => prod.City); 
        }
    }
}

