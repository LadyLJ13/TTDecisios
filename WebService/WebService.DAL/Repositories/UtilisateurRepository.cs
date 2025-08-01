using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.DAL.Data;
using WebService.Domain.Entities;
using WebService.Domain.Interfaces;

namespace WebService.DAL.Repositories
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        private readonly WebServiceDbContext _context;

        public UtilisateurRepository(WebServiceDbContext context)
        {
            _context = context;
        }

        #region GetAll 

        public async Task<IEnumerable<Utilisateur>> GetAll(string filtreNom = null, string filtrePrenom = null)
        {
            var query = _context.Utilisateurs.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filtreNom))
            {
                query = query.Where(u => u.Nom.ToLower().Contains(filtreNom.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(filtrePrenom))
            {
                query = query.Where(u => u.Prenom.ToLower().Contains(filtrePrenom.ToLower()));
            }

            return await query.ToListAsync();
        }
        #endregion

        #region GetById 

        public async Task<Utilisateur> GetById(Guid id)
        {
            return await _context.Utilisateurs.FirstOrDefaultAsync(u => u.Id == id);
        } 
        #endregion

        #region Create 

        public async Task<Utilisateur> Create(Utilisateur utilisateur)
        {
            _context.Utilisateurs.Add(utilisateur);
            await _context.SaveChangesAsync();
            return utilisateur;
        }
        #endregion

        #region Update 

        public async Task<Utilisateur> Update(Utilisateur utilisateur)
        {
            _context.Utilisateurs.Update(utilisateur);
            await _context.SaveChangesAsync();
            return utilisateur;
        }
        #endregion

        #region Delete 

        public async Task Delete(Guid id)
        {
            Utilisateur utilisateur = await _context.Utilisateurs.FindAsync(id);
            if (utilisateur != null)
            {
                _context.Utilisateurs.Remove(utilisateur);
                await _context.SaveChangesAsync();
            }
        } 
        #endregion
    }
}
