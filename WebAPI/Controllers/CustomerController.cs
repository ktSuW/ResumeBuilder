using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetCustomer()
        {
            return Ok("Sam");
        }

        [HttpPost]
        [Route("~/api/v2/[controller]/[action]")]
        public ActionResult CreateCustomer(Customer customer)
        {

            return Ok(customer);
        }

        [HttpPut]
        public ActionResult UpdateCustomer(int id)
        {
            return Ok($"Updated = {id}");
        }

        [HttpDelete]
        public ActionResult DeleteCustomer(int id)
        {
            //try
            //{
            //return id == 12 ? Ok($"Deleted = {id}") : NotFound("Not found, cannot delete");
            //} catch
            //{
            //    return NotFound("");
            //}
            throw new Exception("Message error");
            
        }
    }
}
