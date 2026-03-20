using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    internal class ComputerRepository
    {
        private Dictionary<string, Computer> _computers;

        public ComputerRepository()
        {
            _computers = new Dictionary<string, Computer>();
        }

        public List<Computer> All
        {
            get { return _computers.Values.ToList(); }
        }

        public void Insert(string serialNo, Computer aComputer)
        {
            if (!_computers.ContainsKey(serialNo))
            {
                _computers.Add(serialNo, aComputer);
            }
        }

        public void Delete(string serialNo)
        {
            _computers.Remove(serialNo);
        }
    }
}
