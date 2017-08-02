using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryInterface
{
    /// <summary>
    /// Generic Interfce for CRUID operations
    /// </summary>
    /// <typeparam name="T">Generic class</typeparam>
    /// <typeparam name="TKey">complex id</typeparam>
    public interface IRepository<T, TKey> where T : class
    {
        /// <summary>
        /// Fetches all records from datasource
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Get();

        /// <summary>
        /// Get record by using id from data source
        /// </summary>
        /// <param name="id">Id of the object to be fetched</param>
        /// <returns>Returns the records</returns>
        T Get(TKey id);

        /// <summary>
        /// Insert record into datasource
        /// </summary>
        /// <param name="obj">record to be added</param>
        /// <returns>Returns the inserted record</returns>
        T Insert(T obj);

        /// <summary>
        /// Update record 
        /// </summary>
        /// <param name="obj">Generic object to be update</param>
        /// <returns>returns updated object</returns>
        T Update(T obj);

        /// <summary>
        /// Delete record from datasource
        /// </summary>
        /// <param name="id">id of object to be deleted</param>
        void Delete(TKey id);
    }
}
