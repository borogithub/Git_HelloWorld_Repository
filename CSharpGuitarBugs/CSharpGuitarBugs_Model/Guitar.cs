using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuitarBugs_Model
{
    public class Guitar
    {
        public int Id = -1;
        public string Manufacturer = null;
        public string ModelName = null;
        public string ModelNumber = null;
        public string ModelDescription = null;     
        public TypeOfGuitar GuitarType;
        public TypeOfString StringType;
        public TypeOfBody BodyType;
        public TypeOfMic MicType;
    }
}
