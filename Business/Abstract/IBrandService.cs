using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Abstract
{
    public interface IBrandService
    {

        //Bana bir marka var o markayı sana tekrardan döndüreyim!
        CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);

        List<GetAllBrandResponse> GetAll();




    }
}
