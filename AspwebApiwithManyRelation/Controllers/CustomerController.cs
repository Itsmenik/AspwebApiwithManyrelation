using AspwebApiwithManyRelation.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspwebApiwithManyRelation.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly CustomerDbContext _customerDBContext; // we declare here private and read only 

        public CustomerController(CustomerDbContext customerDBContext) //injecting context into the Contructor class contructor
                                                                       
        {
            _customerDBContext = customerDBContext; // assigning the context to the same name context  

            // the upper _customerDBContext is assigned to customerDBContext 

        }

        //Now the action method (lagical peiece of code that excute acc to the htt request mehof
        [HttpGet]
        
        public async Task<IActionResult> Get()
        {
            // var customer = await _customerDBContext.Customers.ToListAsync(); // generally it will run as sql state (select * from Customer)  
            // we want the adress also so for  that
            var customer = await _customerDBContext.Customers
               .Include(_=>_.Addresses).ToListAsync(); //Include it means table mei 
            ///left join hoga internally (Slect * from customer then leftjoin of adress in the customer ) 
            return Ok(customer); 
            

        }

    }
}
