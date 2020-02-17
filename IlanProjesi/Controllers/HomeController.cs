using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IlanProjesi.Data;
using IlanProjesi.Models;
using IlanProjesi.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace IlanProjesi.Controllers
{
	public class HomeController : Controller
	{
		ArabaRepository _arabaRep;
		ArabaKonutIsModel _model;
		
		KonutRepository _konutRep;

		public HomeController(ArabaRepository araba,ArabaKonutIsModel model,KonutRepository konut)
		{
			_arabaRep = araba;
			_model = model;
			_konutRep = konut;
			//_ısRep = ıs;

		}
		//PC\SQLEXPRESS
		public IActionResult Index()
		{
			return View();
		}


		public IActionResult ListAraba()
		{
			_model.Arabalar = _arabaRep.Doldur();
			return View(_model);
		}

		public IActionResult ListKonut()
		{
			_model.Konutlar = _konutRep.Doldur();
			return View(_model);
		}








	}
}
