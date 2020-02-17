using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IlanProjesi.DTO
{
	public class KonutDTO
	{
		public int KonutId { get; set; }
		public decimal KonutFiyat { get; set; }
		public string KonutAdres { get; set; }
		public string KonutAçıklama { get; set; }
		public string KonutResim { get; set; }
	}
}
