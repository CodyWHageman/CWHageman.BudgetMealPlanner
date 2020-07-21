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
    public class PantryController : ControllerBase
    {
        private readonly IPantryService _pantryService;

        public PantryController(IPantryService pantryService)
        {
            _pantryService = pantryService;
        }

        // GET: api/<PantryController>
        [HttpGet]
        public ActionResult Get()
        {
            var pantryItems = _pantryService.GetAll();

            return Ok(pantryItems);
        }

        // GET api/<PantryController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var pantryItem = _pantryService.Get(id);

            return Ok(pantryItem);
        }

        // POST api/<PantryController>
        [HttpPost]
        public ActionResult Post([FromBody] PantryItemDto pantryItem)
        {
            _pantryService.Add(pantryItem);

            return NoContent();
        }

        // PUT api/<PantryController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] PantryItemDto pantryItem)
        {
            _pantryService.Update(pantryItem);

            return NoContent();
        }

        // DELETE api/<PantryController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _pantryService.Delete(id);

            return NoContent();
        }
    }
}
