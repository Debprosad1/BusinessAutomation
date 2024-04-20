using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repositories;
using BusinessAutomationApp.Models;
using BusinessAutomationApp.Models.Customer;
using Microsoft.AspNetCore.Mvc;

namespace BusinessAutomationApp.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository _customerRepository; 
        public CustomerController(CustomerRepository customerRepository)
        {
            CustomerTable = new List<CustomerCreate>();
            _customerRepository = customerRepository;
            
        }

        public IActionResult Index()
        {
            TempData["ABC"] = "Create GET";
           
            return View();
        }



        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Data = TempData["ABC"];
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerCreate customer)
        {
            if (customer.Phone!=null && customer.Phone.Length != 11)
            {
                ModelState.AddModelError("Phone", "Phone must be 11 digit!");
            }


            ViewBag.Data = TempData["ABC"];

            if (ModelState.IsValid)
            {
                //data save operation

                var entity = new Customer()
                {
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone
                };

                var isSuccess = _customerRepository.Add(entity);

                if (isSuccess)
                {
                    ViewBag.SuccessMessage = "Saved Successfully!";

                    return View("Success");
                }
                
            }


            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            var customerList = new List<CustomerCreate>() { 
                
                new CustomerCreate()
                {
                    Name="Mr.A",
                    Phone="01701010101",
                    Email ="a@mail.com"
                },
                new CustomerCreate()
                {
                    Name="Mr.B",
                    Phone="01701010102",
                    Email ="b@mail.com"
                },
                new CustomerCreate()
                {
                    Name="Mr.C",
                    Phone="01701010103",
                    Email ="c@mail.com"
                }
            };

            //ViewBag.CustomerList = customerList;
            //ViewData["CustomerList"] = customerList;

            var company = new Company()
            {
                CompanyId = "C001",
                Name = "ABC Company",
                Location = "Kawranbazar Dhaka"

            };

            var customerListVM = new CustomerList()
            {
                Company = company,
                Customers = customerList
            };


            return View(customerListVM);
        }





        public string CreateList(List<CustomerCreate> customers)
        {
            string message = "";
            foreach(var customer in customers)
            {
               message += $"This is the create page for Customer: {customer.Name} Phone:{customer.Phone}\n";
            }

            return message;
        }


        public static List<CustomerCreate> CustomerTable; 
    }
}
