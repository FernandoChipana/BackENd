using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Entities
{
	public class fmedicos
	{
		[ Key]
		public String cmp { get; set; }
		public String NOMB { get; set; }
		public String SERV { get; set; }
		public String Nº_ESP { get; set; }
		public String DNI { get; set; }
		public DateTime FEC_NAC { get; set; }
		public String celu { get; set; }
		public String email { get; set; }
		public String nombres { get; set; }
		public String especialidad { get; set; }
		



	}
}
