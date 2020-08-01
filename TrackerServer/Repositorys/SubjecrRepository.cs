using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using TrackerServer.DAL;
using TrackerServer.model;

namespace TrackerServer.Repositorys
{
    public class SubjectSubjectRepository:ISubjectRepository
    {
        private ILogger<SubjectSubjectRepository> _logger;
        private ApplicationContext _context;
        public SubjectSubjectRepository(ILogger<SubjectSubjectRepository> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IEnumerable<Subject> Subjects()
        {
            return _context.Subjects.ToList();
        }

        public void Save(Subject subject)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Subjects.Add(subject);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception e)
            {
                _logger.LogError(e.StackTrace);
            }
        }
    }
}