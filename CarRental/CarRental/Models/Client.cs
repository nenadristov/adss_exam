using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Client
    {
        //: Name,
        //Age,
        //Passport Number.
        //All these three fields should be required fields. Age must be a number between 18 and 70.
        [Required]
        public string Name { get; set; }
        [Required]
        [RangeAttribute(18, 70)]
        public int Age { get; set; }
        
        [Required]
        public string PassportNumber { get; set; }
        public virtual Car Cars { get; set; }

    }
}
