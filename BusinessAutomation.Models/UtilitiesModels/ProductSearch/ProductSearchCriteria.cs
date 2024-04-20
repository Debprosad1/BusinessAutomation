using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Models.UtilitiesModels.ProductSearch
{
    public class ProductSearchCriteria
    {
        public double? FromPrice { get; set; }
        public double? ToPrice { get; set; }
        public string? SearchKey { get; set; }

    }
}
