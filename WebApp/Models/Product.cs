using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace WebApp.Models
{
    public class Product : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Estoque { get; set; }
        public double Valor { get; set; }
    }
}
