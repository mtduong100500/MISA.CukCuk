using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Interfaces.Infrastructures;
using MISA.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MISAEntityController<MISAEntity> : ControllerBase
    {

        #region Declare
        IBaseService<MISAEntity> _baseService;
        IBaseRepository<MISAEntity> _baseRepository;
        #endregion

        #region Constructor
        public MISAEntityController(IBaseService<MISAEntity> baseService, IBaseRepository<MISAEntity> baseRepository)
        {
            _baseRepository = baseRepository;
            _baseService = baseService;
        }
        #endregion

        #region Methods
        [HttpGet]
        public IActionResult Get()
        {
            var entity = _baseRepository.getAll();
            return Ok(entity);
        }

        [HttpGet("{customerId}")]

        public IActionResult Get(Guid entityId)
        {
            var entity = _baseRepository.GetById(entityId);
            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Post(MISAEntity entity)
        {
            var res = _baseService.Insert(entity);
            if (res == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(res);
            }
        }
        #endregion

    }
}
