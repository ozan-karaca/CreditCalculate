using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCalculate.Model.Models.Entity;

namespace CreditCalculate.Model.Models.Mapping
{
   public class CreditMap:EntityTypeConfiguration<Credit>
    {
     public CreditMap()
        {
            ToTable("Credit");
            HasKey(x=>x.Id);

            Property(x=>x.age).IsRequired();
            Property(x => x.credit).IsRequired();

            //navigation Properties
        }
    }
}
