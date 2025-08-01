using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.Domain.Entities;

namespace WebService.Domain.Interfaces
{
    public interface IUtilisateurRepository
    {
        Task<IEnumerable<Utilisateur>> GetAll(string filtreNom = null, string filtrePrenom = null);
        Task<Utilisateur> GetById(Guid id);
        Task<Utilisateur> Create(Utilisateur utilisateur);
        Task<Utilisateur> Update(Utilisateur utilisateur);
        Task Delete(Guid id);
    }
}
