using ApiCall.BusinessLogic;
using ApiCall.InputData;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        public IShoppingRepository _IShoppingRepository;

        public ShoppingController(IShoppingRepository iShoppingRepository)
        {
            _IShoppingRepository = iShoppingRepository;
        }
        // GET: api/<Shopping>
        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _IShoppingRepository.GetAllItems());
        }


        // POST api/<Shopping>
        [HttpPost]
        public IActionResult Post([FromBody] ShoppingInput value)
        {
            if (ModelState.IsValid)
            {
                _IShoppingRepository.Add(value);
                return Ok(value);
            }
            return BadRequest("The form field was not completed");
        }
        //// GET api/<Shopping>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// PUT api/<Shopping>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<Shopping>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
