using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using TrackerServer.DAL;
using TrackerServer.model;

namespace TrackerServer.Repositorys
{
    public class SubjectRepository:IRepository
    {
        private ILogger<SubjectRepository> _logger;
        private ApplicationContext _context;
        public SubjectRepository(ILogger<SubjectRepository> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IEnumerable<Subject> Subjects()
        {
            return _context.Subjects.ToList();
        }
    }
}