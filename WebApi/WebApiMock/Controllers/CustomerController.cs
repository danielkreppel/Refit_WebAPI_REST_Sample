using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;
using System.Web.Http;

namespace WebApiMock.Controllers
{    
    [RoutePrefix("api/mock")]
    [Authorize]
    public class CustomerController : ApiController
    {

        [HttpGet]
        [Route("customers")]
        public IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer {Id = Guid.NewGuid(), Name = "Customer 1", Birthday = DateTime.Now.AddYears(-1)},
                new Customer {Id = Guid.NewGuid(), Name = "Customer 2", Birthday = DateTime.Now.AddYears(-2)},
                new Customer {Id = Guid.NewGuid(), Name = "Customer 3", Birthday = DateTime.Now.AddYears(-3)}

            };
            return customers;
        }

        [HttpPost]
        [Route("customers")]
        public ResponseMessage SaveCustomer(Customer customer)
        {
            MemoryCache.Default["customerID"] = customer.Id;
            return new ResponseMessage { Success = true, Message = "Customer Saved!" };
        }

    }
}
