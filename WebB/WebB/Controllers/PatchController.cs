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
    public class PatchController : ApiController
    {
        List<MisterOne> list = new List<MisterOne>();

        [HttpPatch, Route("metricks/projects")]
        //[ActionName("Form")]
        public IEnumerable<MisterOne> Misterone1(MisterOne mr)
        {
            return list;
        }
        [HttpPatch, Route("metricks/users")]
        //[ActionName("Form")]
        public IEnumerable<MisterOne> Misterone2(MisterOne mr)
        {
            return list;
        }
    }
}
