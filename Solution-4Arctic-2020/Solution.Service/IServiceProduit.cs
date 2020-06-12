using Service.Pattern;
using Solution.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Service
{
    public interface IServiceProduit : IService<Produit>
    {
        Produit getProduitByObjet_a_vendre(string name);
    }
}
