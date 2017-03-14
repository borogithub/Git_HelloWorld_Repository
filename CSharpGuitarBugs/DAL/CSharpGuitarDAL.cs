using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom namespaces
using Dapper;
using CSharpGuitarBugs_Model;

namespace DAL
{
    public class CSharpGuitarDAL
    {
        public void Insert(Guitar guitar)
        {
            TO_REMOVE_DAL.Insert(guitar);
        }

        public void Update(Guitar guitar)
        {
            TO_REMOVE_DAL.Update(guitar);
        }

        public void Delete(int id)
        {
            TO_REMOVE_DAL.Delete(id);
        }

        public Guitar Get(int id)
        {
            return TO_REMOVE_DAL.Get(id);
        }

        public List<Guitar> Get()
        {
            return TO_REMOVE_DAL.Get();
        }
    }
}
