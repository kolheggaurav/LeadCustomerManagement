using System.ComponentModel.DataAnnotations;

namespace LeadCustomerManagement.Models
{
    public class Lead
    {
        public int LeadId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact is required")]
        [Phone(ErrorMessage = "Invalid Contact Number")]
        [StringLength(15, ErrorMessage = "Contact cannot be longer than 15 characters")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Company is required")]
        [StringLength(100, ErrorMessage = "Company name cannot be longer than 100 characters")]
        public string Company { get; set; }
    }
}
