using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAPI.HotelListing.API.DTO
{
    public class CreateCountryDTO
    {
        [Required(ErrorMessage = "Country Name is required.")]
        [MaxLength(50,ErrorMessage ="Name should not be more than 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Country Short Name is required.")]
        [StringLength(maximumLength:3, ErrorMessage ="Short name should have only three characters.")]
        public string ShortName { get; set; }
    }
}
