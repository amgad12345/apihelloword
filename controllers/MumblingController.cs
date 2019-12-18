using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace apihelloword.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class MumblingController : ControllerBase
  {

    [HttpGet("{stringValue}")]  // changable to post 
    public ActionResult Getcode(string stringValue)
    {
       var result = string.Join("-", stringValue.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        return Ok(new { theresult = result });
    }

  }

}