using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Infrastructures;
using MISA.Core.Interfaces.Services;
using MISA.Core.Services;
using MISA.Infrastruture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Api.Controllers
{
    [Route("api/v1/customers")]
    [ApiController]
    public class CustomerController : MISAEntityController<Customer>
    {
        ICustomerRepository _customerRepository;
        ICustomerService _customerService;

        public CustomerController(ICustomerService customerService, ICustomerRepository customerRepository):base(customerService, customerRepository)
        {
            _customerService = customerService;
            _customerRepository = customerRepository;
        }

        [HttpGet("Paging")]

        public IActionResult GetPaging(int pageIndex, int pageSize)
        {
            var customers = _customerRepository.GetPaging(pageIndex:pageIndex, pageSize:pageSize);
            return Ok(customers);
        }
    }
}
