using SailClubLibrary.Data;
using SailClubLibrary.Exceptions;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailClubLibrary.Services
{
    /// <summary>
    /// IBoatRepository implementation backed by a LinkedList&lt;Boat&gt;.
    /// Note: lookup operations are linear-time.
    /// </summary>
    public class LinkedListBoatRepository : IBoatRepository
    {
        private readonly LinkedList<Boat> _boats;

        public int Count => _boats.Count;

        public LinkedListBoatRepository()
        {
            // Initialize from existing mock data (previously a Dictionary)
            var initial = new MockData().BoatData.Values;
            _boats = new LinkedList<Boat>(initial);
        }

        public void AddBoat(Boat boat)
        {
            if (boat == null) throw new ArgumentNullException(nameof(boat));

            if (SearchBoat(boat.SailNumber) != null)
            {
                throw new BoatSailnumberExistsException($"Boat med sejlnummeret {boat.SailNumber} findes allerede.");
            }

            _boats.AddLast(boat);
            Console.WriteLine($"Båden med sejlnummeret {boat.SailNumber} er blevet tilføjet til listen");
        }

        public List<Boat> GetAllBoats()
        {
            return _boats.ToList();
        }

        public void RemoveBoat(string sailNumber)
        {
            if (sailNumber == null) return;
            var node = _boats.First;
            while (node != null)
            {
                if (string.Equals(node.Value.SailNumber, sailNumber, StringComparison.OrdinalIgnoreCase))
                {
                    _boats.Remove(node);
                    Console.WriteLine($"Båden med sejlnummer {sailNumber} er blevet fjernet.");
                    return;
                }
                node = node.Next;
            }
        }

        public void UpdateBoat(Boat updatedBoat)
        {
            if (updatedBoat == null) throw new ArgumentNullException(nameof(updatedBoat));
            
            var node = _boats.First;
            while (node != null)
            {
                if (string.Equals(node.Value.SailNumber, updatedBoat.SailNumber, StringComparison.OrdinalIgnoreCase))
                {
                    // Update fields (keep SailNumber as identifier)
                    node.Value.TheBoatType = updatedBoat.TheBoatType;
                    node.Value.Model = updatedBoat.Model;
                    node.Value.EngineInfo = updatedBoat.EngineInfo;
                    node.Value.Draft = updatedBoat.Draft;
                    node.Value.Width = updatedBoat.Width;
                    node.Value.Length = updatedBoat.Length;
                    node.Value.YearOfConstruction = updatedBoat.YearOfConstruction;
                    return;
                }
                node = node.Next;
            }
        }

        public Boat? SearchBoat(string sailNumber)
        {
            if (sailNumber == null) return null;

            foreach (var b in _boats)
            {
                if (string.Equals(b.SailNumber, sailNumber, StringComparison.OrdinalIgnoreCase))
                    return b;
            }
            return null;
        }

        public void PrintAllBoats()
        {
            foreach (var boat in _boats)
            {
                Console.WriteLine(boat.ToString());
            }
            Console.WriteLine();
        }

        public List<Boat> FilterBoats(string filterCriteria)
        {
            if (string.IsNullOrEmpty(filterCriteria))
                return GetAllBoats();

            var filtered = new List<Boat>();
            foreach (var b in _boats)
            {
                if (!string.IsNullOrEmpty(b.Model) &&
                    b.Model.Contains(filterCriteria, StringComparison.OrdinalIgnoreCase))
                {
                    filtered.Add(b);
                }
            }
            return filtered;
        }
    }
}
