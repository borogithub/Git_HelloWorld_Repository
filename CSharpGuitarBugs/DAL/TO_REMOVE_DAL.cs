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
    public static class TO_REMOVE_DAL
    {
        private static List<Guitar> lstGuitars = new List<Guitar>();

        public static void Insert(Guitar guitar)
        {
            lstGuitars.Add(guitar);
        }

        public static void Update(Guitar guitar)
        {
            Guitar foundGuitar = lstGuitars.First(x => x.Id == guitar.Id);
            if(foundGuitar != null)
            {
                foundGuitar.Manufacturer = guitar.Manufacturer;
                foundGuitar.ModelName = guitar.ModelName;
                foundGuitar.ModelNumber = guitar.ModelNumber;
                foundGuitar.ModelDescription = guitar.ModelDescription;
                foundGuitar.GuitarType = guitar.GuitarType;
                foundGuitar.StringType = guitar.StringType;
                foundGuitar.BodyType = guitar.BodyType;
                foundGuitar.MicType = guitar.MicType;
            }
    }

        public static void Delete(int id)
        {
            Guitar foundGuitar = lstGuitars.First(x => x.Id == id);
            if (foundGuitar != null)
            {
                lstGuitars.Remove(foundGuitar);
            }
        }

        public static Guitar Get(int id)
        {
            Guitar foundGuitar = lstGuitars.First(x => x.Id == id);
            return foundGuitar;
        }

        public static List<Guitar> Get()
        {
            return lstGuitars;
        }
    }
}
