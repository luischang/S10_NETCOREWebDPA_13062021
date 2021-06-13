using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S10_NETCoreWebDPA.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S10_NETCOREWebDPA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        [HttpGet]
        [Route("GetCustomer")]
        public async Task<IActionResult> GetCustomer()
        {
            var customers = await _customerRepository.GetCustomers();
            return Ok(customers);          

        }




    }
}
