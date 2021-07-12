using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class CliemsController : ControllerBase
    {
        ICliemService _cliemService;

        public CliemsController(ICliemService cliemService)
        {
            _cliemService = cliemService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _cliemService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Cliem cliem)
        {
            var result = _cliemService.Add(cliem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid={id}")]
        public IActionResult GetById(int id)
        {
            var result = _cliemService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Cliem cliem)
        {
            var result = _cliemService.Delete(cliem);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("update")]
        public IActionResult Update(Cliem cliem)
        {
            var result = _cliemService.Update(cliem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
