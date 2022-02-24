using AutoMapper;
using HotelAPI.HotelListing.API.DTO;
using HotelAPI.HotelListing.API.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAPI.HotelListing.API.Controllers
{
    [Route("api/hotel")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<HotelController> _logger;
        private readonly IMapper _mapper;

        public HotelController(IUnitOfWork unitOfWork, ILogger<HotelController> logger, IMapper map)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = map;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetHotels()
        {
            try
            {
                var hotels = await _unitOfWork.Hotels.GetAll();
                var result = _mapper.Map<List<HotelDTO>>(hotels);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in {nameof(GetHotels)}: {ex}");
                return StatusCode(500, "Internal Server Error. Please try again.");
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetHotel(int id)
        {
            try
            {
                var hotel = await _unitOfWork.Hotels.Get(q => q.Id == id);
                var result = _mapper.Map<HotelDTO>(hotel);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An Error Occured in {nameof(GetHotel)}: {ex}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }
    }
}
