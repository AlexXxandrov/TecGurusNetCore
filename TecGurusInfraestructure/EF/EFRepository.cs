using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusCommon.Domain;
using TecGurusCommon.Interfaces;

namespace TecGurusInfraestructure.EF
{
    /// <summary>
    /// Capa que contiene las queries de cualquier entidad
    /// en la infra puedes tener 1 o muchas Fuentes de Datos
    /// </summary>
    /// <typeparam name="T">Cualquier clase de Domain que se requiera acceder a DB</typeparam>
    public class EFRepository<T> : IEFRepository<T> where T : class
    {
        private readonly DBContextTecGurus _dBContext;


        public EFRepository(DBContextTecGurus dbContext)
        {
            _dBContext = dbContext;
        }

        public IEnumerable<T> GetAll()
        {
            return _dBContext.Set<T>().AsEnumerable();

        }
    }
}
