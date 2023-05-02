using ProjectEntities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMap.Options
{
    public abstract class BaseMap<B> : EntityTypeConfiguration<B> where B : BaseEntity
    {
        public BaseMap()
        {
            
        }
    }
}
