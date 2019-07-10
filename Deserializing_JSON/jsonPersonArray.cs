using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deserializing_JSON
{
    class jsonPersonArray : jsonPersonComplex
    {
        /*
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
        public addr address { get; set; }
        */
        public List<phoneNum> PhoneNumbers { get; set; }
        /*
        public class addr
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string postCode { get; set; }
        }
        */

        public class phoneNum
        {
            public string type { get; set; }
            public string number { get; set; }
        }
    }
}
