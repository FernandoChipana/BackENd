using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Entities
{
    public class fespecialidad
    {
        [Column("Nº_ESP")]
        public String id { get; set; }
        [Column("NOMBRE")]
        public String nombre { get; set; }
    }
}
