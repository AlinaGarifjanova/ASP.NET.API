using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
    public class ContactRegistrationForm
    {
        public string FullName { get; set; } 

        public string Email { get; set; } 

        public string? HiddenSelectInput { get; set; }
        public string? Message { get; set; }
    }
}

