using Service.Pattern;
using Solution.Data.Infrastructure;
using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Service
{
    public class ServiceProduit: Service<Domain.Entities.Produit>, IServiceProduit
    {
        static IDataBaseFactory Factory = new DataBaseFactory();
        static IUnitOfWork utk = new UnitOfWork(Factory);
        public ServiceProduit() : base(utk)
        {

        }

        public void Add(Data.Migrations.Produit entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Data.Migrations.Produit entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Data.Migrations.Produit, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Data.Migrations.Produit Get(Expression<Func<Data.Migrations.Produit, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Produit getLivreurByLastName(string name)
        {
            return Get(f => f.Objet_a_vendre.Equals(name));
        }

        public IEnumerable<Data.Migrations.Produit> GetMany(Expression<Func<Data.Migrations.Produit, bool>> where = null, Expression<Func<Data.Migrations.Produit, bool>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Data.Migrations.Produit getProduitByObjet_a_vendre(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Data.Migrations.Produit entity)
        {
            throw new NotImplementedException();
        }

        Data.Migrations.Produit IService<Data.Migrations.Produit>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Data.Migrations.Produit IService<Data.Migrations.Produit>.GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}