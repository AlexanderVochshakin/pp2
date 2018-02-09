using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Subject
    {
        public string name;

        public Subject(string _name)
        {
            name = _name;
        }
        public Subject() { }
    }
}