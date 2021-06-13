using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S10_NETCoreWebDPA.Domain.Core.Entities;
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

        [HttpGet]
        [Route("GetCustomerById/{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _customerRepository.GetCustomerById(id);
            if (customer == null)
                return NotFound();
            
            return Ok(customer);
        }

        [HttpPost]
        [Route("PostCustomer")]
        public async Task<IActionResult> PostCustomer(Customer customer)
        {
            await _customerRepository.InsertCustomer(customer);
            return Ok(customer);        
        }

        [HttpPut]
        [Route("PutCustomer")]
        public async Task<IActionResult> PutCustomer(Customer customer)
        {
            var result = await _customerRepository.UpdateCustomer(customer);
            if (!result)
                return BadRequest();            
            return Ok(new { result = "Success" });        
        }

        [HttpDelete]
        [Route("DeleteCustomer/{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var result = await _customerRepository.DeleteCustomer(id);
            if (!result)
                return BadRequest();
            return Ok(new { result = result });

        }



    }
}
