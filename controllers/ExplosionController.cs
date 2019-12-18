using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace apihelloword.Controllers
{

  [ApiController]
  [Route("api/[controller]")]

  public class ExplosionController : ControllerBase
  {

    [HttpGet("{stringValue}")]  // changable to post 
    public ActionResult Getcode2(string stringValue)
    {
         var result = string.Join("", stringValue.Select(c => new string(c, int.Parse(c.ToString()))));
        return  Ok(new { theresult = result });


      
    }




  }


}
