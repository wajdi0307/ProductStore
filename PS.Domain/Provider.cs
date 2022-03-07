using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Provider : Concept
    {

        private string confirmPassword;
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        // public string Password { get; set; }
       
        private string password;
        public string UserName { get; set; }
        public List<Product> Products { get; set; }
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length > 20 || value.Length < 5)
                    Console.WriteLine("password  doit être entre 20 et 5");
                else
                    password = value;
            }
        }

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (password != value)
                    Console.WriteLine("verifier mot de passe");
                else
                    confirmPassword = value;
            }
        }

        // passage par référence
        public static void SetIsApproved(Provider p)
        {
            p.IsApproved = p.Password.Equals(p.ConfirmPassword);


        }
        // passage par valeur
        public static void SetIsApproved2(string pass, string confirPassw, bool isApproved)
        {
            isApproved = pass.Equals(confirPassw);

        }

        public static void Calculer(int a, int b,ref int c)
        {
            c = a + b;
        }
    /*    public bool Login(String username, String password)
        {
            return UserName.Equals(username) && Password.Equals(password);
        }*/
        public bool Login(String username, String password, String email= null)
        {
            if(email != null)
            return UserName.Equals(username) && Password.Equals(password) && Email.Equals(email);
            else
                return UserName.Equals(username) && Password.Equals(password);

        }

        public override void GetDetails()
        {
            Console.WriteLine("Nom : " + UserName);        
          /*  for (int i = 0; i <Products.Count; i++)
            {
                Console.WriteLine(Products[i]);
            }*/
            foreach(Product p in Products)
            {
                Console.WriteLine(p);
            }
        }
        public void GetProducts (String filterType , String filterValue)
        {
            switch (filterType)
            {
                case "Name":
                    foreach(Product p in Products)
                    {
                        if(p.Name == filterValue)
                            Console.WriteLine(p);
                    }
                    break;
                case "DateProd":
                    foreach (Product p in Products)
                    {
                        if (p.DateProd == DateTime.Parse(filterValue))
                            Console.WriteLine(p);
                    }
                    break;
                case "Price":
                    foreach (Product p in Products)
                    {
                        if (p.Price == double.Parse(filterValue))
                            Console.WriteLine(p);
                    }
                    break;

            }
        }

    }


}
