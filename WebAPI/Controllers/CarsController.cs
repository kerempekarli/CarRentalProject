using Business.Abstract;
using Business.Concrete;
using Core.Utilities;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {


        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]

        public IActionResult Get()
        {
            var result = _carService.GetAll();
            if (result.Success) {
                return Ok(result);
            }

            else
            {
                return BadRequest(result.Message);
            }
        }
        
        [HttpGet("getbyid")]

        public IActionResult Get(int id)
        {
            var result = _carService.Get(id);
            if (result.Success) {
                return Ok(result);
            }

            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }

            else
            {
                return BadRequest(result.Message);
            }
        }
    }
}
