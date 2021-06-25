using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Entities
{
    public class fmclinic
    {

        [Key]
        [Column("CODC")]
        public int codc { get; set; }
        [Column("NOMB")]
        public String nomb { get; set; }
        [Column("TIPDOC")]
        public String tipdoc { get; set; }
        [Column("NDOC")]
        public String ndoc { get; set; }
        [Column("FENA")]
        [DisplayFormat(DataFormatString = "{yyyy-m-d}", ApplyFormatInEditMode = true)]
        public DateTime fechnac { get; set; }
        [Column("SEXO")]
        public String sexo { get; set; }
        [Column("EMAIL")]
        public String email { get; set; }
        [Column("FONO")]
        public String cel { get; set; }
        
    }
}
