using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using TrackerServer.DAL;
using TrackerServer.model;

namespace TrackerServer.Repositorys
{
    public class ZipcodeRepository : IZipcodeRepository
    {
        private ILogger<ZipcodeRepository> _logger;
        private ApplicationContext _context;
        public ZipcodeRepository(ILogger<ZipcodeRepository> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IEnumerable<ZipCode> Zipcodes()
        {
            return _context.ZipCodes.ToList();
        }

        public IEnumerable<ZipCode> Zipcode(string id)
        {
            return _context.ZipCodes.Where(b => b.Code.Equals(id)).ToList();
        }
    }
}