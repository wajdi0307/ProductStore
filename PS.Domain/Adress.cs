using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    [Owned]
    public class Adress
    {
       
        public String city { get; set; }
        public String streetAdress { get; set; }
    }
}
