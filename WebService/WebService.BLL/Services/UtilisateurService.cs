using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.BLL.Interfaces;
using WebService.BLL.Mappers;
using WebService.BLL.Models;
using WebService.Domain.Entities;
using WebService.Domain.Interfaces;

namespace WebService.BLL.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly IUtilisateurRepository _utilisateurRepository;

        public UtilisateurService(IUtilisateurRepository userRepository)
        {
            _utilisateurRepository = userRepository;
        }

        #region GetAll 

        public async Task<IEnumerable<UtilisateurDto>> GetAll(string filtreNom = null, string filtrePrenom = null)
        {
            var utilisateurs = await _utilisateurRepository.GetAll(filtreNom, filtrePrenom);
            return utilisateurs.Select(UtilisateurMapper.ToDto);
        }
        #endregion

        #region GetById 

        public async Task<UtilisateurDto> GetById(Guid id)
        {
            Utilisateur utilisateur = await _utilisateurRepository.GetById(id);
            return utilisateur.ToDto();
        }
        #endregion

        #region Create 

        public async Task<UtilisateurDto> Create(ShortUtilisateur utilisateur)
        {
            var user = utilisateur.UToDb();
            var createdUser = await _utilisateurRepository.Create(user);
            return createdUser.ToDto();
        }
        #endregion

        #region Update 

        public async Task<UtilisateurDto> Update(Guid id, ShortUtilisateur utilisateur)
        {
            var foundUser = await _utilisateurRepository.GetById(id);
            if (foundUser == null)
            {
                throw new Exception("Utilisateur non trouvé");
            }

            foundUser.Prenom = utilisateur.Prenom;
            foundUser.Nom = utilisateur.Nom;

            var updatedUser = await _utilisateurRepository.Update(foundUser);
            return updatedUser.ToDto();
        }
        #endregion

        #region Delete 

        public async Task Delete(Guid id)
        {
            var foundUser = await _utilisateurRepository.GetById(id);
            if (foundUser is null)
            {
                throw new Exception("Utilisateur non trouvé");
            }

            await _utilisateurRepository.Delete(foundUser.Id);
        } 
        #endregion
    }
}
