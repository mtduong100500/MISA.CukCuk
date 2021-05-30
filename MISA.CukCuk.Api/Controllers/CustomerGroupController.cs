using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Infrastructures;
using MISA.Core.Interfaces.Services;
using MISA.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Api.Controllers
{
    public class CustomerGroupController : MISAEntityController<CustomerGroup>
    {
        IBaseService<CustomerGroup> _baseService;
        IBaseRepository<CustomerGroup> _baseRepository;

        public CustomerGroupController(IBaseService<CustomerGroup> baseService, IBaseRepository<CustomerGroup> baseRepository):base(baseService, baseRepository)
        {
            _baseService = baseService;
            _baseRepository = baseRepository;
        }
    }
}
