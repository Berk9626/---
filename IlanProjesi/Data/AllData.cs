using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IlanProjesi.Data
{
	public class AllData:DbContext
	{
		public AllData(DbContextOptions<AllData> op): base (op)
		{

		}
		DbSet<Araba> araba { get; set; }
		DbSet<Konut> konut { get; set; }
		DbSet<Is> ıs { get; set; }

		public class Araba
		{
			[Key]
			public int ArabaId { get; set; }
			public string ArabaModel { get; set; }
			public decimal ArabaFiyat { get; set; }
			public string ArabaAdres { get; set; }
			public string ArabaAcıklama { get; set; }
			public string ArabaResim { get; set; }
		}

		public class Konut
		{
			[Key]
			public int KonutId { get; set; }
			public decimal KonutFiyat { get; set; }
			public string KonutAdres { get; set; }
			public string KonutAçıklama { get; set; }
			public string KonutResim { get; set; }
		}

		public class Is
		{
			[Key]
			public int IsId { get; set; }
			public string IsAcıklama { get; set; }
			public string IsAdres { get; set; }
			
		}

	}
}
