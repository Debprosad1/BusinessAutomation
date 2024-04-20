using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Models.EntityModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double SalesPrice { get; set; }

        public Brand? Brand { get; set; }
        public int? BrandId { get; set; }

        public bool IsDeleted { get; set; }

        public string GetInfo()
        {
            var message =  $"Name: {Name} Desc. {Description} SalesPrice: {SalesPrice}";

            if (Brand != null)
            {
                message += $" Brand {Brand.Name}";
            }

            return message;
        }
    }
}
