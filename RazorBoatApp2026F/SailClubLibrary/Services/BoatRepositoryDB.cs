using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailClubLibrary.Services
{
    public class BoatRepositoryDB : Connection, IBoatRepository
    {
        public int Count => throw new NotImplementedException();

        public void AddBoat(Boat boat)
        {
            throw new NotImplementedException();
        }

        public List<Boat> FilterBoats(string filterCriteria)
        {
            throw new NotImplementedException();
        }

        public List<Boat> GetAllBoats()
        {
            throw new NotImplementedException();
        }

        public void RemoveBoat(string sailNumber)
        {
            throw new NotImplementedException();
        }

        public Boat? SearchBoat(string sailNumber)
        {
            throw new NotImplementedException();
        }

        public void UpdateBoat(Boat boat)
        {
            throw new NotImplementedException();
        }
    }
}
