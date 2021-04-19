using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using vacaaa.Interfaces;
using vacaaa.Services;

namespace vacaaa.Controllers
{
    
  [ApiController]
  [Route("api/[controller]")]
  public class VacationsController : ControllerBase
  {
    private readonly VacationService _vacationService;

    public VacationsController(VacationService vacationService)
    {
      _vacationService = vacationService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<IInfo>> GetAllPurchasables()
    {
      try
      {
        return Ok(_vacationService.getAll());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

  }
}
