using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.BLL.Models
{
    public class UtilisateurDto
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
