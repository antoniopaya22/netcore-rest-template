using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest_api.Model
{
    public class Grupo
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public User[] Users { get; set; }
    }
}
