using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSocketDemo.WebSockets;

namespace WebSocketDemo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private  ChatRoomHandler chatRoomHandler { get; set; }
        public ValuesController(ChatRoomHandler handler)
        {
            chatRoomHandler = handler;
        }
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            await chatRoomHandler.SendMessageToAllAsync("hello from controller");
            return new string[] { "value1", "value2" };

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
