using IlanProjesi.Data;
using IlanProjesi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IlanProjesi.Data.AllData;

namespace IlanProjesi.Repositories
{
	public class ArabaRepository: BaseRepositories<Araba>
	{

		public ArabaRepository(AllData db) : base(db)
		{
			

		}
		

		public ICollection<ArabaDTO> Doldur()
		{
			return  Set().Select(x => new ArabaDTO
			{
				ArabaId = x.ArabaId,
				ArabaAcıklama = x.ArabaAcıklama,
				ArabaAdres = x.ArabaAdres,
				ArabaFiyat= x.ArabaFiyat,
				ArabaModel = x.ArabaModel,
				ArabaResim = x.ArabaResim

			}).ToList();


		}
		
	}
}
