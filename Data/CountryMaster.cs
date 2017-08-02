using Core;
using Core.Models;
using Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Data
{
    public class CountryMaster : ICountry<Tbl_Country, string[], string>
    {
        DummyEntities context = new DummyEntities();
        public void Delete(string[] id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tbl_Country> Get()
        {
            throw new NotImplementedException();
        }

        public Tbl_Country Get(string[] id)
        {
            throw new NotImplementedException();
        }

        public Tbl_Country Insert(Tbl_Country obj)
        {
            context.Tbl_Country.Add(obj);
            context.SaveChanges();
            throw new NotImplementedException();
        }

        public Tbl_Country Update(Tbl_Country obj)
        {
            throw new NotImplementedException();
        }
    }
}
