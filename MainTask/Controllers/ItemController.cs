using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MainTask.Models;
using MainTask.Services;
using MainTask.Interfaces;

namespace MainTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItem _item;

        public ItemController(IItem item)
        {
            _item = item;
        }
        [Authorize]
        [HttpPost("create")]

        public IActionResult Create([FromBody] Item item)
        {
            _item.CreateItem(item);
            return NoContent();
        }
        [Authorize]
        [HttpGet("getItems")]
        public IActionResult GetItems()
        {
            return Ok(_item.GetItems());
        }
        [Authorize(Roles = "admin,user")]
        [HttpGet("{id}")]
        public IActionResult GetItemById(int id)
        {
            var i = _item.GetItemById(id);
            if (i == null)
            {
                return NotFound();
            }
            return Ok(i);
        }
        [Authorize(Roles ="admin")]
        [HttpPut("update")]
        public IActionResult UpdateTask(Item item,int id)
        {
            _item.UpdateItem(item,id);
            return NoContent();
        }
        [Authorize(Roles = "admin")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _item.DeleteItem(id);
            return NoContent();
        }
    }
}
