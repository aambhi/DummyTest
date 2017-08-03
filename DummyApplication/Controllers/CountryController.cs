using Core;
using Core.RepositoryInterface;
using DummyApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyApplication.Controllers
{
    public class CountryController : Controller
    {
        private readonly IRepository<Tbl_Country, string> _countryrepository;

        /// <summary>
        /// Create a new instance of the AIPP.SSSDataBrowser.Api.Controllers.InstrumentController class
        /// </summary>
        /// <param name="instrumentRepository"></param>
        public CountryController(IRepository<Tbl_Country, string> countryrepository)
        {
            this._countryrepository = countryrepository;
        }

        // GET: Country
        public ActionResult Create(CountryModel country, string id = null)
        {
            //dummy application123
            //Branch 1
            //New Branch 2
            return View();
        }
        [HttpPost]
        public ActionResult Create(CountryModel country)
        {
            Tbl_Country _country = new Tbl_Country();

            _country.CountryName = country.CountryName;

            var count = _countryrepository.Insert(_country);
            return View();
        }

    }
}