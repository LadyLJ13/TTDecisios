using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.BLL.Models;

namespace WebService.BLL.Interfaces
{
    public interface IUtilisateurService
    {
        Task<IEnumerable<UtilisateurDto>> GetAll(string filtreNom = null, string filtrePrenom = null);
        Task<UtilisateurDto> GetById(Guid id);
        Task<UtilisateurDto> Create(ShortUtilisateur utilisateur);
        Task<UtilisateurDto> Update(Guid id, ShortUtilisateur utilisateur);
        Task Delete(Guid id);
    }
}
