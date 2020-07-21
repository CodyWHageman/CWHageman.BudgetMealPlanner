using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWHageman.BudgetMealPlanner.DataAccess.DataTransferObjects;
using CWHageman.BudgetMealPlanner.DataAccess.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CWHageman.BudgetMealPlanner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookDatesController : ControllerBase
    {
        private readonly ICookDatesService _cookDatesService;

        public CookDatesController(ICookDatesService cookDatesService)
        {
            _cookDatesService = cookDatesService;
        }

        // GET: api/<CookDatesController>
        [HttpGet]
        public ActionResult Get()
        {
            var hasMonth = Request.Query.TryGetValue("Month", out var monthStr);

            if (!hasMonth) return BadRequest("Must include Month and the numeric value in the query string.");

            var isNumeric = int.TryParse(monthStr, out var month);

            if (!isNumeric) return BadRequest("Month must be numeric.");

            return Ok(_cookDatesService.GetByMonth(month));
        }

        // GET api/<CookDatesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var cookDate = _cookDatesService.Get(id);

            return Ok(cookDate);
        }

        // POST api/<CookDatesController>
        [HttpPost]
        public ActionResult Post([FromBody] CookDateDto cookDate)
        {
            _cookDatesService.Add(cookDate);

            return NoContent();
        }

        // PUT api/<CookDatesController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] CookDateDto cookDate)
        {
            _cookDatesService.Update(cookDate);

            return NoContent();
        }

        // DELETE api/<CookDatesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _cookDatesService.Delete(id);

            return NoContent();
        }
    }
}
