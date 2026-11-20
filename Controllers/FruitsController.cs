using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MYFirstApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        public List<string> fruits = new List<string> 
        { "Apple", "Banana", "Cherry" };
        [HttpGet]
        public List<string> GetFruits()
        {
            return fruits;
        }
        [HttpPost]
        public List<string> AddFruit([FromBody] string fruit)
        {
            fruits.Add(fruit);
            return fruits;
        }
        [HttpGet("{id}")]
        public string GetFruits(int id)
        {
            if (id < fruits.Count)
            {
                return fruits[id];

            }
            else
            {
                return "Out of index";
            }
        }

    }
}
