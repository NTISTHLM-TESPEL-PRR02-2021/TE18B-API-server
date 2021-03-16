using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers
{

  [ApiController]
  [Route("api/pokemon")]
  public class PokemonController: ControllerBase
  {

    static List<Pokemon> pokemons = new List<Pokemon>()
    {
      new Pokemon() {Name = "Pikachu"},
      new Pokemon() {Name = "Charmander"}
    };

    
    [HttpGet]
    public ActionResult Get()
    {
      return Ok(pokemons[0]);
    }

  }
}
