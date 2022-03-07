using Data;
using PS.Domain;
using PS.Service;
using System;
using System.Collections.Generic;
namespace PS.GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*      Product p = new Product();

                  Product p1 = new Product(123, "wajdi");
                  p.Name = "hello";
                  Console.WriteLine(p1.Quantite);
                   p.DateProd = new DateTime(2022, 1 , 31) ;*/
            Product p2 = new Product()
            {
                Name = "tomate",
                DateProd = DateTime.Now,
                 Quantite = 3222,
                 Price= 35869,
             };
            Product p3 = new Product()
            {
                DateProd = new DateTime(2020,10,20),

                Name = "orange",
                Quantite = 3222,
                Price = 35879,
            };
/*            Console.WriteLine(p2);
*/            Provider provider = new Provider()
            {
                UserName = "wajdi",
                Email = "wajdi@esprit.tn",
                Password = "acdeeb",
                ConfirmPassword = "acdeeb"

            };
            Product product = new Product()
            {

            };
            Chemical chemical1 = new Chemical()
            {
                Name = "chemical",
                Price = 20,
                MyAdress =
                {
                     city ="Tunis"
                }
               

            };
            Chemical chemical3 = new Chemical()
            {
                Name = "chemical3",
                Price = 50,
                MyAdress =
                {
                     city ="paris"
                }
              

            };
            Chemical chemical2 = new Chemical()
            {
                Name = "chemical2",
                Price = 30,
                MyAdress =
                {
                   city = "nabeul"

                }

            };
            Product biological = new Biological();
           
/*            Console.WriteLine(provider.IsApproved);
*/            //passage par référence
            /*Provider.SetIsApproved(provider);
            Console.WriteLine(provider.IsApproved);*/
            //passagepar Valeur 
            Provider.SetIsApproved2(provider.Password, provider.ConfirmPassword, provider.IsApproved);
/*            Console.WriteLine(provider.IsApproved);
*/            /* p.DateProd =  DateTime.Now;
             Console.WriteLine(p.DateProd);*/
            int j = 5;
            int i = 3;
            int k = 2;
            /*  Provider.Calculer(j, i,ref k);*/
            /*            Console.WriteLine(k);
            */
            Console.WriteLine(provider.Login("wajdi", "acdeeb"));
            Console.WriteLine(provider.Login("wajdi", "acdeeb", "wajdi@esprit.tn"));
            product.GetMyType();
            chemical1.GetMyType();
            biological.GetMyType();
            List<Product> products = new List<Product>
            {
              
            };
            products.Add(p2);
            products.Add(p3);
            products.Add(chemical1);

            products.Add(chemical2);

            products.Add(chemical3);

            provider.Products = products;
          /*  provider.GetDetails();*/
            provider.GetProducts("Price", "35879");
            Console.WriteLine(products[0]);
            Console.WriteLine("---------------------------------------------------------");
            manageProduct mp  = new manageProduct();
            mp.lsProduct = products;
            foreach(Product pp in mp.FindProduct('o'))
                Console.WriteLine(pp);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");

            foreach (Chemical pc in mp.getShemical(5))
            {
                Console.WriteLine(pc);
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");

            foreach (Chemical pc in mp.GetShemicalCity())
            {
                Console.WriteLine(pc);
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");

            foreach (var  g in mp.GetChemicalGroupByCity())
            {
                Console.WriteLine(g.Key);
                foreach (Chemical pc in  g)
                {
                    Console.WriteLine(pc);
                }
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            String s = "bonjour";
            Console.WriteLine(StringExtension.upper(s));
            Console.WriteLine("------------------------------------------------------------------------------------------");
            PSContext ctx = new PSContext();
            ctx.Products.Add(p2);
            ctx.Products.Add(chemical1);
            ctx.Products.Add(chemical3);
            ctx.Products.Add(chemical2);
            ctx.SaveChanges();
        }

    }
}
