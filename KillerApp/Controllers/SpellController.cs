using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KillerAppLibrary.Services;
using KillerAppLibrary.Models;

namespace KillerApp.Controllers
{
  [Route("api/[controller]/[action]")]
  public class SpellController : Controller
  {
    private readonly SpellService service;

    public SpellController(SpellService service)
    {
      this.service = service;
    }
    [HttpPost]
    public IEnumerable<Spell> GetAllSpells()
    {
      return service.GetAllSpells();
    }

  }
}
