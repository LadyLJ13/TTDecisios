using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Domain.Entities
{
    public class Utilisateur
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Prenom { get; set; }
        public required string Nom { get; set; }
    }
}
