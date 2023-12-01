using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Car
    //Model,
    //Manufacturer,
    //Photo,
    //Year of Manufacture.
    //Model and Manufacturer should be required fields.
    //Year of Manufacture must be a number and the field for inserting it must have label "Year of Manufacture" including the spaces between the words.
    //Photo (if available) must be displayed as a photo.
    {
        [Required]
        public string Model { get; set; }
        [Required]
        public string Manufacturer { get; set; }

        public string Photo { get; set; } //the type is string because ideally the image will be stored in cloud and in the db only the url will be stored
        [Display(Description = "Years Of Manufacture")]
        public int YearOfManufacture { get; set; }
        public int ClientId { get; set; }
        public virtual ICollection<Client> Clients  { get; set; }
    }
}
