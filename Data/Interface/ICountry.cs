using Core.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface ICountry<T, TKey, TKey1> : IRepository<T, TKey> where T : class
    {

    }
}
