using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Entities
{
    public class turnos
    {
        [Key]
        [Column("Cmp")]
        public String id { get; set; }
        [Column("Turcod")]
        public String turcod { get; set; }
        [Column("codcon")]
        public decimal codcon { get; set; }
        [Column("turuni")]
        public String turini { get; set; }
        [Column("turfin")]
        public String turfin { get; set; }
        [Column("turtime")]
        public String turtime { get; set; }
        [Column("Lun")]
        public String lun { get; set; }
        [Column("Mar")]
        public String mar { get; set; }
        [Column("Mie")]
        public String mie { get; set; }
        [Column("Jue")]
        public String jue { get; set; }
        [Column("Vier")]
        public String vier { get; set; }
        [Column("Sab")]
        public String sab { get; set; }
        [Column("Dom")]
        public String dom { get; set; }
        [Column("Obs")]
        public String obs { get; set; }
        [Column("Estado")]
        public String estado { get; set; }
    }
}
