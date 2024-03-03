using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dump.Api.Controllers
{
    [ApiController, AllowAnonymous]
    public class DumpController : Controller
    {
        [HttpGet, Route("")]
       public Boolean Dump()
       {
            return false;
       }
    }
}
