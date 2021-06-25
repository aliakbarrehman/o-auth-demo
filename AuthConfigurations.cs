using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O_Auth_Demo
{
    public class AuthConfigurations
    {
        public const String Auth = "Auth";
        
        public String Authority { get; set; }
        public String Audience { get; set; }
    }
}
