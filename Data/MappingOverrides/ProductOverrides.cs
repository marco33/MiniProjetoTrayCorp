using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.MappingOverrides
{
    public class ProductOverrides : IAutoMappingOverride<Product>
    {
        public void Override(AutoMapping<Product> mapping)
        {
        }
    }
}
