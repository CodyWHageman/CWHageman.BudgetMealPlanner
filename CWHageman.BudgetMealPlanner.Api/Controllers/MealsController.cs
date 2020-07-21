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
    public class MealsController : ControllerBase
    {
        private readonly IMealsService _mealsService;

        public MealsController(IMealsService mealsService)
        {
            _mealsService = mealsService;
        }

        // GET: api/<MealsController>
        [HttpGet]
        public ActionResult Get()
        {
            var meals = _mealsService.GetAll();

            return Ok(meals);
        }

        // GET api/<MealsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var meal = _mealsService.Get(id);

            return Ok(meal);
        }

        // POST api/<MealsController>
        [HttpPost]
        public ActionResult Post([FromBody] MealDto meal)
        {
            _mealsService.Add(meal);

            return NoContent();
        }

        // PUT api/<MealsController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] MealDto meal)
        {
            _mealsService.Update(meal);

            return NoContent();
        }

        // DELETE api/<MealsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _mealsService.Delete(id);

            return NoContent();
        }
    }
}
