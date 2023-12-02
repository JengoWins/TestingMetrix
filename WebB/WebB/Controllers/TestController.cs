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
    public class TestController : ApiController
    {
        List<MisterOne> list = new List<MisterOne>();
        [HttpPost,Route("Misterone")]
        [ActionName("Form")]
        public IEnumerable<MisterOne> Misterone(MisterOne mr)
        {
            //static readonly Dictionary<Guid, Update> updates = new Dictionary<Guid, Update>();

            MisterOne first = new MisterOne()
            {
                Id = HttpUtility.HtmlEncode(mr.Id),
                Summary = HttpUtility.HtmlEncode(mr.Summary)
            };

            list.Add(first);
            return list;
        }
    }
}
