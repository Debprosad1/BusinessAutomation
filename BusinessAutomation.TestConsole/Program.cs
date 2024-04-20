// See https://aka.ms/new-console-template for more information

//CRUD

// Create Product 

using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Repositories;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;

//BusinessAutomationDbContext db = new BusinessAutomationDbContext();

//var product = db.Products.FirstOrDefault(c => c.Id == 2);

//Console.WriteLine("Before Load....");
//Console.WriteLine(product.GetInfo());

//db.Entry(product).Reference(c => c.Brand).Load();

//Console.WriteLine("After Load....");
//Console.WriteLine(product.GetInfo());


//ProductsRepository productRepository = new ProductsRepository();

//Console.WriteLine("Provide search key: ");
//string searchKey = Console.ReadLine();


//double? fromPrice = null;
//double? toPrice = 60000;

//var searchCriteria = new ProductSearchCriteria()
//{
//    SearchKey = searchKey,
//    FromPrice = fromPrice,
//    ToPrice = toPrice
//};

//var products = productRepository.SearchProduct(searchCriteria);



// LINQ classic approach 

//SELECT p.Name, p.Description, p.SalesPrice FROM Products p WHERE p.SalesPrice>2000 AND p.SalesPrice<=5000

//var existingProducts = from p in db.Products
//                       join b in db.Brands on p.BrandId equals b.Id into pb
//                       from prodBrand in pb.DefaultIfEmpty()
//                       //where p.SalesPrice > 10000 && p.SalesPrice <= 50000
//                       select new Product() {Name=p.Name, Id = p.Id, Brand=prodBrand };



//foreach (var product in products)
//{

//        Console.WriteLine(product.GetInfo());
//}


//List<int> numbers = new List<int>();

//List<Product> products = new List<Product>();


var customer = new Customer()
{
    Name = "Mr. A",
    Email = "a@mail.com",
    Phone = "92389902",
    Address = "Dhaka"
};

CustomerRepository customerRepository = new CustomerRepository();

bool isAdded = customerRepository.Add(customer);

if (isAdded)
{
    Console.WriteLine("Customer Added.");
}









