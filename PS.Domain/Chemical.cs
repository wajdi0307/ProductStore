﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Chemical : Product
    {

        public String LabName { get; set; }
        public Adress MyAdress { get; set; } = new Adress();
        public override void GetMyType()
        {
            base.GetMyType(); 
            Console.WriteLine("chemical");
        }
    }
}
