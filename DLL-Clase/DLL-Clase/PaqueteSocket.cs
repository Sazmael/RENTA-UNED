using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Clase
{
    [Serializable]
    public class PaqueteSocket<T> //Clase generica personalizada
    {
        public string Metodo { get; set; }
        public T Entidad { get; set; }

    }
}
