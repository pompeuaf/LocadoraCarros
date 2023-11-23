using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraBack.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        public string user { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool user_act { get; set; }

    }
}