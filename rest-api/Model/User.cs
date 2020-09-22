using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest_api.Model
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Lastname { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
    }
}
