using System.Collections.Generic;
using TrackerServer.model;

namespace TrackerServer.Repositorys
{
    public interface IZipcodeRepository
    {
        IEnumerable<ZipCode> Zipcodes();
        IEnumerable<ZipCode> Zipcode(string id);
    }
}