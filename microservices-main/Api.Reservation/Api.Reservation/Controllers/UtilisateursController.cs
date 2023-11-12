using Api.Reservation.Business.Models;
using Api.Reservation.Business.Service;
using Api.Reservation.Datas.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Reservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateursController : ControllerBase
    {
        // TODO

        // GET: api/<UtilisateursController>
        private readonly IUtilisateurService _utilisateurService;
        public UtilisateursController(IUtilisateurService utilisateurService)
        {
            _utilisateurService = utilisateurService;
        }
        [HttpGet]
        public async Task<IActionResult> CreateUserAsync([FromBody] CreateUser utilisateur)
        {
            try
            {
                var createUser = new Datas.Entities.Utilisateur()
                {
                    Id = utilisateur.Id,
                    Nom = utilisateur.Nom,
                    Prenom = utilisateur.Prenom,
                    Email = utilisateur.Email,
                    DateNaissance = utilisateur.DateNaissance
                };

                return Ok(await _utilisateurService.CreateUserAsync(createUser));
            }
            catch (Exception e) { return Problem(e.Message, e.StackTrace); }
        }

        // GET api/<UtilisateursController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UtilisateursController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UtilisateursController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UtilisateursController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
