using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using CreditCalculate.Model.Models.Entity;

namespace CreditCalculate.DAL.Abstract
{
    public interface ICreditDAL : IEntityRepository<Credit>
    {
    }
}
