using AutoMapper;
using HotelAPI.HotelListing.API.Data;
using HotelAPI.HotelListing.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAPI.HotelListing.API.Extensions
{
    public class MapperExtension : Profile
    {
        public MapperExtension()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
        }
    }
}
