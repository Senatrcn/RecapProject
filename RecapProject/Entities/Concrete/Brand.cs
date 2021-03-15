using RecapProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.Entities.Concrete
{
    public class Brand:IEntity
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
    }
}
