using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCalculate.DAL.Concrete.EntityFramework.Context;
using Ninject.Modules;

namespace CreditCalculate.DAL.IoC
{
    public class DALModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<DbContext>().To<CreditCalculateDBContext>();
        }
    }
}
