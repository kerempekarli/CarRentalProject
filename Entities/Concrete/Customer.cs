﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }

        public Customer(int id, int userId, string companyName)
        {
            ID = id;
            UserId = userId;
            CompanyName = companyName;
        }
    }
}
