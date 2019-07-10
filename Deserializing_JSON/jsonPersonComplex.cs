using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    {
        "firstname" : "Roger",
        "lastname" : "Moore",
        "age" : "89",
        "isAlive" : false,
        "address" :
        {
            "streetAddress" : "1 Main Street",
            "city" : "London",
            "postCode" : "N1 3XX"
        },
        "phoneNumbers" :
        [
            { "type" : "home","number":"+61 03 1234 5678"},
            { "type" : "mobile","number":"+61 0405 111 222"}
        ]
     
    }
     
*/
namespace Deserializing_JSON
{
    class jsonPersonComplex : jsonPersonSimple
    {   
        /*
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
        */
        public addr address { get; set; }
        

        public class addr
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string postCode { get; set; }
        }
    }
}
