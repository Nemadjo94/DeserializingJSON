using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * {
 *    "firstname" : "Roger",
 *    "lastname" : "Moore",
 *    "age" : 89,
 *    "isAlive" : false
 * }
 * 
 */
namespace Deserializing_JSON
{
    class jsonPersonSimple
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
    }
}
