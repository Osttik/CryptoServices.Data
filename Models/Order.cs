using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServices.Data.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string CurrentState { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
