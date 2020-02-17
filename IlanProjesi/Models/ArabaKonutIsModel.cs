using IlanProjesi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IlanProjesi.Models
{
	public class ArabaKonutIsModel
	{
		public ICollection<ArabaDTO> Arabalar { get; set; }
		public ICollection<IsDTO> Isler { get; set; }
		public ICollection<KonutDTO> Konutlar { get; set; }
		public ArabaDTO ArabaDTO { get; set; }
		public KonutDTO KonutDTO { get; set; }
		public IsDTO IsDTO { get; set; }
	}
}

