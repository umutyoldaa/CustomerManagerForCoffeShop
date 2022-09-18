﻿using CustomerManagerForCoffeShop.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagerForCoffeShop.Entities
{
   public  class Customer:IEntities
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationaltylId { get; set; }
    }
    
}
