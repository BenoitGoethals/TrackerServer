using System.Collections.Generic;
using TrackerServer.model;

namespace TrackerServer.Repositorys
{
    public interface ISubjectRepository
    {
        public IEnumerable<Subject> Subjects();
        public void Save(Subject subject);
    }
}