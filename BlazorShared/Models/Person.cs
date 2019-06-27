using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorShared.Models
{
    public class Person
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 aand 100 characters")]
        public string Name { get; set; }

        [Required]        
        [Phone()]
        public string Phone { get; set; }
    }
}   
