using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creación_estructura.Class.NewFolder
{
    public abstract class miembrocomunidad
    {
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }

        public miembrocomunidad(string nombre, string correoElectronico)
        {
            Nombre = nombre;
            CorreoElectronico = correoElectronico;
        }

    }
}
