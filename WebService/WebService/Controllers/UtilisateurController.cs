using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebService.BLL.Interfaces;
using WebService.BLL.Models;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IUtilisateurService _utilisateurService;

        public UtilisateurController(IUtilisateurService utilisateurService)
        {
            _utilisateurService = utilisateurService;
        }

        #region GetAll 

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<UtilisateurDto>>> GetAll([FromQuery] string filtreNom = null, [FromQuery] string filtrePrenom = null)
        {
            var utilisateurs = await _utilisateurService.GetAll(filtreNom, filtrePrenom);
            return Ok(utilisateurs);
        }
        #endregion

        #region GetById 

        [HttpGet("{id}")]
        public async Task<ActionResult<UtilisateurDto>> GetById(Guid id)
        {
            try
            {
                UtilisateurDto foundUser = await _utilisateurService.GetById(id);
                if (foundUser is null)
                {
                    return NotFound(new { message = "Pas d'utilisateur correspondant à cet ID" });
                }
                return Ok(foundUser);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    message = "Une erreur est survenue",
                    detail = ex.Message,
                    innerException = ex.InnerException?.Message,
                    stackTrace = ex.StackTrace
                });
            }
        }
        #endregion

        #region Create 

        [HttpPost]
        public async Task<ActionResult<UtilisateurDto>> Create([FromBody] ShortUtilisateur utilisateur)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var user = await _utilisateurService.Create(utilisateur);
                return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Erreur lors de la création de l'utilisateur" });
            }
        }
        #endregion

        #region Update 

        [HttpPut("{id}")]
        public async Task<ActionResult<UtilisateurDto>> Update(Guid id, [FromBody] ShortUtilisateur utilisateur)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                    return BadRequest(new { Errors = errors });
                }

                var foundUser = await _utilisateurService.GetById(id);
                if (foundUser is null)
                {
                    return NotFound();
                }

                var updatedUser = await _utilisateurService.Update(id, utilisateur);
                return Ok(updatedUser);
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Erreur lors de la mise à jour de l'utilisateur" });
            }
        }
        #endregion

        #region Delete 

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                var foundUser = _utilisateurService.GetById(id);
                if (foundUser is null)
                {
                    return NotFound();
                }

                await _utilisateurService.Delete(id);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Erreur lors de la mise à jour de l'utilisateur" });
            }
        } 
        #endregion
    }
}
