using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories.Abstractions.Products
{
    public interface IProductRepository
    {
         ICollection<Product> GetAll();
         bool Add(Product entity) ;
        bool Update(Product product);
        public bool Remove(Product product);

        Product GetById(int id);
        ICollection<Product> SearchProduct(ProductSearchCriteria searchCriteria);
    }
}
