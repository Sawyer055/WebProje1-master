using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APICustomerController : ControllerBase
    {
        Context c=new Context();
        // GET: api/<APICustomerController>
        [HttpGet]
        public List<Customer> Get()
        {
            return c.Customers.ToList();
        }

        // GET api/<APICustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            var customer = c.Customers.FirstOrDefault(x => x.CustomerID == id);

            return customer;
        }

        // POST api/<APICustomerController>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            c.Customers.Add(customer);
            c.SaveChanges();
        }

        // PUT api/<APICustomerController>/5
        [HttpPut("{id}")]
        //public IActionResult Put(int id, [FromBody] Customer cstmr)
        //{
        //    var customers=c.Customers.FirstOrDefault(y => y.CustomerID == id);
        //    if(customers is null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        customers.CustomerName=cstmr.CustomerName;
        //        customers.CustomerSurname=cstmr.CustomerSurname;
        //        customers.CustomerEmail=cstmr.CustomerEmail;
        //        customers.CustomerPhoneNumber=cstmr.CustomerPhoneNumber;    
        //        customers.CustomerPassword=cstmr.CustomerPassword;
        //    }
        //}

        // DELETE api/<APICustomerController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var customers=c.Customers.FirstOrDefault(x=>x.CustomerID == id);
            if(customers is null) 
            {
                return NotFound(); 
            }
            else
            {
                c.Remove(customers);
                c.SaveChanges() ;
                return Ok();

            }

        }
    }
}
