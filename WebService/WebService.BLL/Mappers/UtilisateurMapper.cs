using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using db = WebService.Domain.Entities;
using dto = WebService.BLL.Models;

namespace WebService.BLL.Mappers
{
    public static class UtilisateurMapper
    {
        public static dto.UtilisateurDto ToDto(this db.Utilisateur db)
        {
            return new dto.UtilisateurDto
            {
                Id = db.Id,
                Nom = db.Nom,
                Prenom = db.Prenom
            };
        }

        public static db.Utilisateur ToDB(this dto.UtilisateurDto dto)
        {
            return new db.Utilisateur
            {
                Id = dto.Id,
                Nom = dto.Nom,
                Prenom = dto.Prenom
            };
        }

        public static dto.ShortUtilisateur UToDto(this db.Utilisateur dto)
        {
            return new dto.ShortUtilisateur
            {
                Nom = dto.Nom,
                Prenom = dto.Prenom
            };
        }

        public static db.Utilisateur UToDb(this dto.ShortUtilisateur dto)
        {
            return new db.Utilisateur
            {
                Nom = dto.Nom,
                Prenom = dto.Prenom
            };
        }
    }
}
