using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Repositories.Abstractions.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories
{
    public class ProductCloudRepository : IProductRepository
    {

        public bool Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Product product)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> SearchProduct(ProductSearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
