using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Common.Models
{

    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return $"Customer Details: Id - {Id}, Name - {Name}, Birthday - {Birthday.ToShortDateString()}";
        }
    }
}
