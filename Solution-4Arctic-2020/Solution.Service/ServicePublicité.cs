using Service.Pattern;
using Solution.Data.Infrastructure;
using Solution.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.Service
{
    public class ServicePublicité : Service<Publicité>, IServicePublicité
    {
        static IDataBaseFactory Factory = new DataBaseFactory();
        static IUnitOfWork utk = new UnitOfWork(Factory);
        public ServicePublicité() : base(utk)
        {

        }

        public IQueryable<Publicité> Publicités { get; set; }
    }

}