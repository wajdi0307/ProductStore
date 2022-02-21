using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domains
{
    public class Product
    {
        //propriété c est l'attribut avec le getter et le setter and to create prop condanc" en écrit prop double tab et en change selone nos besoins et pour affecter on ecrit = "abc";
        public String Description { get; set; } 
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantite { get; set; }
        public DateTime DateProd { get; set; }
        public string Name { get; set ; }
        public Category Category { get; set; }
        public List<Provider> Providers { get; set; }
        public Product()
        {

        }

        public override string ToString()
        {
            return "Name = "+ Name + " Quantite = "+ Quantite + " Price = " + Price ;
        }

        /*  public Product(string description, double price, int productId, int quantite, DateTime dateProd, string name, Category category, List<Provider> providers)
          {
              Description = description;
              Price = price;
              ProductId = productId;
              Quantite = quantite;
              DateProd = dateProd;
              Name = name;
              Category = category;
              Providers = providers;
          }

          public Product(int quantite, string name)
          {
              Quantite = quantite;
              Name = name;
          }
  */


        /*    public DateTime getDateProd()
{
return dateProd;
}
public void setDateProd(DateTime value)
{
dateProd = value;
}*/

        public virtual void GetMyType()
        {
            Console.WriteLine("je suis un prouit");
         
        }
    }
}
