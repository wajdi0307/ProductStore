using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Product
    {        //propriété c est l'attribut avec le getter et le setter and to create prop condanc" en écrit prop double tab et en change selone nos besoins et pour affecter on ecrit = "abc";

        
        [DataType(DataType.MultilineText)]
        public String Description { get; set; } 
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public int ProductId { get; set; }
        [Range(0,int.MaxValue)]
        public int Quantite { get; set; }
        [Display(Name = "date de  production")]
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }
        [Required(ErrorMessage ="le nom est obligatoire")]
        [MaxLength(25, ErrorMessage ="le nom ne doit pas depaase 25")]//input length
        [StringLength(50)]//property length
        public string Name { get; set ; }
        //public int? CategoryId { get; set; }
        [ForeignKey("Category")]
        public int? CategoryFk { get; set; }
        //[ForeignKey("CategoryFk")] si le foreignkey sur la relation 
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
