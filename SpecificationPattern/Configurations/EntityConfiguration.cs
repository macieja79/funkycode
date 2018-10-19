using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyCode
{
    public class EntityConfiguration <TEntity> : EntityTypeConfiguration<TEntity> where TEntity : Entity
    {
        public EntityConfiguration()
        {
            HasKey(p => p.Id);
        }

    }
}
