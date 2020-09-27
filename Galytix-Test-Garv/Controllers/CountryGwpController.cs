using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galytix_Test_Garv.DTO.CountryGwp;
using Galytix_Test_Garv.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Galytix_Test_Garv.Controllers
{
    [Route("server/api/gwp")]
    [ApiController]
    public class CountryGwpController : ControllerBase
    {
        public ICountryGwpService _countryGwpService { get; set; }
        private readonly ILogger _logger;

        public CountryGwpController(ICountryGwpService countryGwpService, ILogger<CountryGwpController> logger)
        {
            _countryGwpService = countryGwpService;
            _logger = logger;
        }

        /// <summary>
		/// Get a list of average gross written premium (GWP) over 2008-2015 period for the selected lines of business.
		/// </summary>		
		/// <returns>A list of average GWP.</returns>
		/// <response code="200">request was processed successfully.</response>
		/// <response code="400">argument is missing or wrong, and it's correctness required to process your call.</response>		
        [HttpPost("avg")]
        [ProducesResponseType(typeof(List<AvgPostResponseDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<AvgPostResponseDto>>> GetAverage([FromBody] AvgPostRequestDto data)
        {
            try
            {              
                if (string.IsNullOrWhiteSpace(data.CountryCode))
                    return BadRequest("Country Code can't be null");

                if (data.LobList.Count == 0)
                    return BadRequest("Lob can't be empty");
                return _countryGwpService.GetAvgGwp(data.CountryCode, data.LobList);                
            }
            catch(Exception e)
            {
                _logger.LogError("GetAverage Error" + e.Message);
                return BadRequest();
            }
        }
    }
}
