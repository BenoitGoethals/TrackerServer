using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrackerServer.model;
using TrackerServer.Repositorys;

namespace TrackerServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public IEnumerable<ZipCode> Get()
        {
            return _repository.Zipcodes();
        }
        

        [HttpGet("{id}")]
        public IEnumerable<ZipCode> Get(string id) => _repository.Zipcode(id);

    }
}