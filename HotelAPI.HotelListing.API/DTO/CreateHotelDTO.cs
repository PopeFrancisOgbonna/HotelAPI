using HotelAPI.HotelListing.API.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAPI.HotelListing.API.DTO
{
    public class CreateHotelDTO
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Address is a required fireld.")]
        public string Address { get; set; }
        public double Rating { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
