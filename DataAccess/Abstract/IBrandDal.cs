using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBrandDal
    {
        void Add(Brand brand);

        List<Brand> GetAll();
        //Tüm Markaları Listeleme işlemi!
    }
}
