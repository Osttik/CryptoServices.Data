﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MassTransit.MessageHeaders;

namespace CryptoServices.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LoginHash { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<Order> Orders { get; }
    }
}
