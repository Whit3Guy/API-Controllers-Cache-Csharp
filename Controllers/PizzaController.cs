using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aprendendo_pizza.models;
using aprendendo_pizza.services;
using Microsoft.AspNetCore.Mvc;

namespace aprendendo_pizza.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
        }
        //Get all
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();


        //Get by Id
        [HttpGet("{id}")]
        public ActionResult<Pizza>? Get(int id){  
            Pizza? maybePizza = PizzaService.Get(id);

            if(maybePizza is null){
                return NotFound() ;
            }

            return maybePizza;
        }

        //Post
        [HttpPost]
        public IActionResult Post(Pizza pizza){
            PizzaService.Add(pizza);
            return CreatedAtAction(nameof(Get), new {id = pizza.id}, pizza);
        }

        //Update
        [HttpPut("{id}")]
        public IActionResult Put(Pizza pizza, int id){
            if(pizza.id != id){
             return BadRequest();
            }

            var PizzaExists = PizzaService.Get(id);
            if(PizzaExists is null){
                return NotFound();
            }

            PizzaService.Update(pizza, id);
                
            return CreatedAtAction(nameof(Get),new { id = pizza.id}, pizza);
        }

        
        //Delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var PizzaExists = PizzaService.Get(id);
            if(PizzaExists is null){
                return NotFound();
            }
            
            PizzaService.Delete(id);

            return NoContent();
        }
    }
}