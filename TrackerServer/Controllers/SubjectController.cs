using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrackerServer.model;
using TrackerServer.Repositorys;

namespace TrackerServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(typeof(IEnumerable), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public class SubjectController : ControllerBase
    {
        private readonly ILogger<SubjectController> _logger;
        private ISubjectRepository _subjectRepository;

        public SubjectController(ILogger<SubjectController> logger,ISubjectRepository subjectRepository)
        {
            _logger = logger;
            _subjectRepository = subjectRepository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IEnumerable<Subject> Get()
        {
            return _subjectRepository.Subjects();
        }
        
        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public void Add([FromBody]Subject subject)
        {
            _subjectRepository.Save(subject);
        }
    }
}