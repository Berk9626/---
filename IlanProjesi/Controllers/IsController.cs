using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IlanProjesi.Models;
using IlanProjesi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IlanProjesi.Controllers
{
    public class IsController : Controller
    {
		IsRepository _ısRep;
		ArabaKonutIsModel _model;
		public IsController(IsRepository ıs , ArabaKonutIsModel model)
		{
			_ısRep = ıs;
			_model = model;

		}

        public IActionResult List()
        {
			_model.Isler = _ısRep.Doldur();
            return View(_model);
        }
    }
}