using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Entities
{
	public class fmedicos
	{
		[ Key]
		public String cmp { get; set; }
		public String nomb { get; set; }
		public String serv { get; set; }
		[Column("Nº_ESP")]
		public String NESP { get; set; }
		
		public String dni { get; set; }
		[Column("FEC_NAC")]
		public DateTime FECNAC { get; set; }
		public String celu { get; set; }
		public String email { get; set; }
		public String nombres { get; set; }
		public String especialidad { get; set; }
		



	}
}
