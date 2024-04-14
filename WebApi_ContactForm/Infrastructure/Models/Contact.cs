
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class Contact
    {
       // public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FullName { get; set; } = null!;

        [EmailAddress]
        public string Email { get; set; } = null!;
        public string? Message { get; set; }
        public string? HiddenSelectInput { get; set; }
    }
}
