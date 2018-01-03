using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace CreditCalculate.Model.Models.Entity
{
    public class Credit : IEntity
    {
        // properties
        public int age { get; set; }
        public int credit { get; set; }
        public int Id { get; set; }
    }
}
