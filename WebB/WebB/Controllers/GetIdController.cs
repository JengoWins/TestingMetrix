using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.UI.WebControls;
using WebAdaptation4.Model;

namespace WebA.Controllers
{
    public class GetIdController : ApiController
    {
        List<MisterOne> list = new List<MisterOne>();
        [HttpGet, Route("metricks/projects")]
        //[ActionName("Form")]
        public IEnumerable<MisterOne> Misterone1([FromBody] int id)
        {
            return list;
        }
        [HttpGet, Route("metricks/users")]
        //[ActionName("Form")]
        public IEnumerable<MisterOne> Misterone2([FromBody] int id)
        {
            return list;
        }
    }
}
