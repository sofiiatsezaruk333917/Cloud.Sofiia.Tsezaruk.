using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace HostelNaUOA.Core
{
    public class HostelServices : IHostelServices
    {
        private readonly IMongoCollection<Hostel> _hostel;
        public HostelServices(IDbClient dbClient)
        {
            _hostel = dbClient.GetHostelCollection();
        }

        public Hostel AddHostel(Hostel hostel)
        {
            _hostel.InsertOne(hostel);
            return hostel;
        }

        public void DeleteHostel(string id)
        {
            _hostel.DeleteOne(hostel => hostel.Id == id);
        }

        public Hostel GetHostel(string id) => _hostel.Find(hostel => hostel.Id == id).First();

        public List<Hostel> GetHostels()=> _hostel.Find(hostel => true).ToList();
        

        public Hostel UpdateHostel(Hostel hostel)
        {
            GetHostel(hostel.Id);
            _hostel.ReplaceOne(h => h.Id == hostel.Id, hostel);
            return hostel;
        }
    }
}
