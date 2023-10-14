using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace quiz_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return new Models.Question[] {
                new Models.Question() { Text = "Hello"},
                new Models.Question() { Text = "hi"}
            };
        }

        [HttpPost]
        public void Post([FromBody] Models.Question question)
        {
            
        }
    }
}
