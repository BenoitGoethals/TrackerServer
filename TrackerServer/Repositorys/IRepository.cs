using System.Collections.Generic;
using TrackerServer.model;

namespace TrackerServer.Repositorys
{
    public interface IRepository
    {
        public IEnumerable<Subject> Subjects();
    }
}