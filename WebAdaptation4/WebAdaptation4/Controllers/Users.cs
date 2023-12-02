using Microsoft.AspNetCore.Mvc;
using WebAdaptation4.Model;

namespace WebAdaptation4.Controllers
{
    [Route("/metricks/[controller]")]
    [ApiController]
    public class Users : ControllerBase
    {
        [HttpGet]
        public ActionResult<MisterOne> Get()
        {
            MisterOne one = new MisterOne()
            {
                id = 1,
                Summary = "Nulls"
            };
            return one;
        }
        [HttpGet("{id}")]
        public ActionResult<MisterOne> Get(int id)
        {
            MisterOne one = new MisterOne()
            {
                id = 1,
                Summary = "Nulls"
            };
            return one;
        }
        [HttpPost]
        public ActionResult<MisterOne> Post()
        {
            MisterOne one = new MisterOne()
            {
                id = 1,
                Summary = "Nulls"
            };
            return one;
        }
        [HttpPut("{id}")]
        public ActionResult<MisterOne> Put(int id)
        {
            MisterOne one = new MisterOne()
            {
                id = 1,
                Summary = "Nulls"
            };
            return one;
        }
    }
}
