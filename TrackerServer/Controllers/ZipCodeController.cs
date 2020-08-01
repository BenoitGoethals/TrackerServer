using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrackerServer.model;
using TrackerServer.Repositorys;

namespace TrackerServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
  
    [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
    public class ZipCodeController : ControllerBase
    {
      
        private readonly ILogger<ZipCodeController> _logger;
        private IZipcodeRepository _repository;

        public ZipCodeController(ILogger<ZipCodeController> logger,IZipcodeRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Produces("application/xml")] 
        public IEnumerable<ZipCode> Get()
        {
            return _repository.Zipcodes();
        }
        

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IEnumerable), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IEnumerable<ZipCode> Get(string id) => _repository.Zipcode(id);

    }
}