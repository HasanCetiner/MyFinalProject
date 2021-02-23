using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(); 
        List<Product> GetAllByCategoryId(int Id); 
        List<Product> GetAllByUnitPrice(decimal min, decimal max); 
        
    }
}
 