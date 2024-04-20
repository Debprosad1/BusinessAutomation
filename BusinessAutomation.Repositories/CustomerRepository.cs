using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        BusinessAutomationDbContext db;
        public CustomerRepository(BusinessAutomationDbContext db)
        {
            this.db =db;
            _db = db;
        }
    }
}
