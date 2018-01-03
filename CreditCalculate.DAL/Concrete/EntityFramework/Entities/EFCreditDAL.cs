using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using CreditCalculate.DAL.Abstract;
using CreditCalculate.DAL.Concrete.EntityFramework.Context;
using CreditCalculate.Model.Models.Entity;

namespace CreditCalculate.DAL.Concrete.EntityFramework.Entities
{
    public class EFCreditDAL : EFEntityRepositoryBase<Credit, CreditCalculateDBContext>, ICreditDAL
    {
        public EFCreditDAL(DbContext context)
            : base(context)
        {

        }
    }


}
