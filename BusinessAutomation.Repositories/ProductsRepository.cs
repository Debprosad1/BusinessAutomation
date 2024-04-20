using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Repositories.Abstractions.Products;
using BusinessAutomation.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories
{
    public class ProductsRepository : BaseRepository<Product>, IProductRepository
    {
        BusinessAutomationDbContext db;
        public Guid Guid { get; set; }
       
        public ProductsRepository(BusinessAutomationDbContext db)
        {
            Guid = Guid.NewGuid();
            Debug.WriteLine("Product Repository is created with: "+ Guid.ToString());

            this.db = db;
            _db = db; 
        }

        public BusinessAutomationDbContext Db { 
            get {
                return db; 
            }
            set {
                db = value; 
            }
        }
        public Product GetById(int id)
        {
            var existingProduct = db.Products.FirstOrDefault(c => c.Id == id);

            return existingProduct;
        }
        public ICollection<Product> SearchProduct(ProductSearchCriteria searchCriteria)
        {
            var searchKey = searchCriteria.SearchKey;

            var products = db.Products
                    .Include(c => c.Brand).AsQueryable();

            if (!string.IsNullOrEmpty(searchKey))
            {
                products = products.Where(c => c.Name.ToLower().Contains(searchKey.ToLower())
                || c.Description.ToLower().Contains(searchKey.ToLower())
                  || (c.Brand == null ? false : c.Brand.Name.ToLower().Contains(searchKey.ToLower()))

                );
            }

            if (searchCriteria.FromPrice != null)
            {
                products = products.Where(c => c.SalesPrice > searchCriteria.FromPrice);
            }

            if (searchCriteria.ToPrice != null)
            {
                products = products.Where(c => c.SalesPrice <= searchCriteria.ToPrice);
            }


            return products.ToList();

        }
        
    
    
    }
}
