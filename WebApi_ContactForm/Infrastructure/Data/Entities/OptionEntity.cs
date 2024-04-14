using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Infrastructure.Data.Entities
{
    public class OptionEntity
    {
        [Key]
        public int Id { get; set; }
        public string? OptionName { get; set; } 
    }
}
