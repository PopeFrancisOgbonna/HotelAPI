using HotelAPI.HotelListing.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAPI.HotelListing.API.DTO
{
    public class CountryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}
