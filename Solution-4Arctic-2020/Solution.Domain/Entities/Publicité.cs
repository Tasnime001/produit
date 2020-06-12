using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
   public class Publicité
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }
        public double Prix_initial { get; set; }
        public double Prix_promotion  { get; set; }
       
    }
}
    
