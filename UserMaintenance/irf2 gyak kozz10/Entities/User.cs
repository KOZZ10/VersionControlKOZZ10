﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irf2_gyak_kozz10.Entities
{
    public class User
    {   
        public Guid ID { get; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int myVar;

        public string FullName
        {
            get { 
                return string.Format(
                    "{0}{1}", 
                    LastName, 
                    FirstName);
            }
        }

    }
}
