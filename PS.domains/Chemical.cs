using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domains
{
    public class Chemical : Product
    {
        public String City { get; set; }
        public String LabName { get; set; }
        public String StreetAdress { get; set; }
        public override void GetMyType()
        {
            base.GetMyType(); 
            Console.WriteLine("chemical");
        }
    }
}
