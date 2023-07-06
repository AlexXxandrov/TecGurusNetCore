using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TecGurusCommon.Interfaces
{

    //Capa que contiene las queries de cualquier entidad en la infra puedes tener 1 o muchas Fuentes de Datos

    //<typeparam name="T"></typeparam>

    public interface IEFRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
