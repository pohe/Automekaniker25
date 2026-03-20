using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    public class Repository<K, V>
    {
        private Dictionary<K, V> _repo;

        public int Count { get { return _repo.Count; } }
        public Repository()
        {
            _repo = new Dictionary<K,V>();
        }

        public List<V> All
        {
            get { return _repo.Values.ToList(); }
        }

        public void Insert(K k, V aV)
        {
            if (!_repo.ContainsKey(k))
            {
                _repo.Add(k, aV);
            }
        }

        public void Delete(K k)
        {
            _repo.Remove(k);
        }

        public void PrintAll()
        {
            foreach (V item in _repo.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}

