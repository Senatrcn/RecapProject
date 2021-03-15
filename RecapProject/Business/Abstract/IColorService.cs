using RecapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Delete(Color color);
        List<Color> GetAll();
    }
}
