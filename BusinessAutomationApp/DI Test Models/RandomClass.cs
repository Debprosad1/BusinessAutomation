using BusinessAutomation.Repositories;
using System.Diagnostics;

namespace BusinessAutomationApp.DI_Test_Models
{
    public class RandomClass
    {
        ProductsRepository _productRepository; 
        public RandomClass(ProductsRepository productsRepository)
        {
            _productRepository = productsRepository;
            Debug.Write("Product Repo Guid in Random Class: " + productsRepository.Guid.ToString());
        }
    }
}
