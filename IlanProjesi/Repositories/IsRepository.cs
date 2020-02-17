using IlanProjesi.Data;
using IlanProjesi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IlanProjesi.Data.AllData;

namespace IlanProjesi.Repositories
{
	public class IsRepository : BaseRepositories<Is>
	{
		public IsRepository(AllData db) : base (db)
		{

		}
		public ICollection<IsDTO> Doldur()
		{
			return Set().Select(x => new IsDTO
			{
				IsId = x.IsId,
				IsAcıklama = x.IsAcıklama,
				IsAdres = x.IsAdres


			}).ToList();
		}
	}
}
