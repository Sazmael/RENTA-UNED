using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Clase
{
    public class Clientes
    {
        private String identificacion;
        private String nombre;
        private String primer_apellido;
        private String segundo_apellido;
        private DateTime fecha_nacimiento;
        private char genero;

        //Constructores
        public Clientes()
        {
        }

        public Clientes(string identificacion, string primer_apellido, string segundo_apellido, DateTime fecha_nacimiento, char genero)
        {
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.Primer_apellido = primer_apellido;
            this.Segundo_apellido = segundo_apellido;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Genero = genero;
        }

        //Metodos
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Primer_apellido { get => primer_apellido; set => primer_apellido = value; }
        public string Segundo_apellido { get => segundo_apellido; set => segundo_apellido = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public char Genero { get => genero; set => genero = value; }
        
    }
}
