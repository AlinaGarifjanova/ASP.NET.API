using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Entities
{
    public class ContactEntity
    {
        [Key]
        public string Id { get; set; } 
        public string FullName { get; set; } 
        public string Email { get; set; }
        public string? Message { get; set; }
        public string? HiddenSelectInput { get; set; }

        public OptionEntity? Option { get; set; }

    }
}
