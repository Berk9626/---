using IlanProjesi.Data;
using IlanProjesi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IlanProjesi.Data.AllData;

namespace IlanProjesi.Repositories
{
	public class KonutRepository: BaseRepositories<Konut> 
	{
		public KonutRepository(AllData db): base (db)
		{

		}

		public ICollection<KonutDTO> Doldur()
		{
			return Set().Select(x => new KonutDTO
			{
				KonutId = x.KonutId,
				KonutAdres = x.KonutAdres,
				KonutAçıklama = x.KonutAçıklama,
				KonutFiyat = x.KonutFiyat,
				KonutResim= x.KonutResim
				
			}).ToList();

		}
		
		




	}
}
