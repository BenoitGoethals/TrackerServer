using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrackerServer.model;
using TrackerServer.Repositorys;

namespace TrackerServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectController : ControllerBase
    {
        private readonly ILogger<SubjectController> _logger;
        private IRepository _repository;

        public SubjectController(ILogger<SubjectController> logger,IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Subject> Get()
        {
            return _repository.Subjects();
        }
    }
}