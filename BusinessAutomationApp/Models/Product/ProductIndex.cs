namespace BusinessAutomationApp.Models.Product
{
    public class ProductIndex
    {
        public string SearchKey { get; set; }

        public ICollection<ProductListItem> ProductList { get; set; }
    }

}
