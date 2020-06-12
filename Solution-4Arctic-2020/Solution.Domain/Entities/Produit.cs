using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
    public class Produit
    {
        public int Id { get; set; } 
        public string Objet_a_vendre  { get; set; }
        public string Image { get; set; }
        public string Categorie  { get; set; }
        public string Description { get; set; }
        public double Prix { get; set; }
        public string Code_a_barre { get; set; }
    }
}
