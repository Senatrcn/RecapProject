using RecapProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.Entities.Concrete
{
    public class Color:IEntity
    {
        public int ColorId { get; set; }
        public string Name { get; set; }
    }
}
