using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCalculate.Model.Models.Entity;
using CreditCalculate.Model.Models.Mapping;

namespace CreditCalculate.DAL.Concrete.EntityFramework.Context
{
    public class CreditCalculateDBContext : DbContext
    {
        public CreditCalculateDBContext()
            : base("Server=DESKTOP-KUCAFVB;Database=CreditCalculate;UID=sa;Password=Lenovo2344.;")
        {

        }
        public DbSet<Credit> Credit { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        modelBuilder.Configurations.Add(new CreditMap());
        }
    }
}
