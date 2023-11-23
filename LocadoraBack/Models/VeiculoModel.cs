using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraBack.Models
{
    public class VeiculoModel
    {
        public long Id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public DateTime ano { get; set; }
        public float valor { get; set; }
        public string combustivel { get; set; }
        public bool veiculo_act { get; set; }

    }
}