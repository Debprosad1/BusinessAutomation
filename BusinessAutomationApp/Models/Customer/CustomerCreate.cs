using System.ComponentModel.DataAnnotations;

namespace BusinessAutomationApp.Models.Customer
{
    public class CustomerCreate
    {
        public CustomerCreate()
        {

        }
        public CustomerCreate(string name)
        {
            Name = name;

        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }

        public string? Email { get; set; }
    }
}
