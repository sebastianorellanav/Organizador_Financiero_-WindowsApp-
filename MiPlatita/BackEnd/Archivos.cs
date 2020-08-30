using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlatita.BackEnd
{
    class Archivos
    {
        public Boolean comprobarUsuario()
        {
            var path = Path.GetFullPath("../../DatosUsuario/nombreUsuario.txt");
            String nombre = File.ReadAllText(path);
            if (nombre.Equals(""))
            {
                return false;
            }
            return true;
        }
    }
}
