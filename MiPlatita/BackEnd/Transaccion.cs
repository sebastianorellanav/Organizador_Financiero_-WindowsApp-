using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiPlatita.BackEnd
{
    class Transaccion
    {
        public int id { get; set; }
        public String tipo { get; set; }
        public String donde { get; set; }
        public DateTime cuando { get; set; }
        public Int32 monto { get; set; }

        public List<Transaccion> obtenerTodasTransacciones() 
        {
            //Leer el archivo donde estan las transacciones
            var path = Path.GetFullPath("../../DatosUsuario/Transacciones.txt");
            string[] lineas = System.IO.File.ReadAllLines(path);
            //guardarlas en una variable
            List<Transaccion> lista = new List<Transaccion>();
            
            if (lineas == null){
                return null;
            }
       
            foreach ( String linea in lineas)
            {
                Console.WriteLine(linea);
                Transaccion tr = new Transaccion();
                String[] separado = linea.Split( ',', '\n' );
                tr.id = Int16.Parse(separado[0]);
                tr.tipo = separado[1];
                tr.donde = separado[2];
                tr.cuando = DateTime.Parse(separado[3]);
                tr.monto = Int32.Parse(separado[4]);
                lista.Add(tr);
            }
            //retornar las transacciones
            return lista;
        }

        public void GuardarTransaccion(Transaccion nueva_tr)
        {
            //obtengo todas las transacciones en una lista
            List<Transaccion> transacciones = this.obtenerTodasTransacciones();
            //agrego la nueva transaccion
            transacciones.Add(nueva_tr);
            //ordeno la lista
            IEnumerable<Transaccion> transaccionesOrdenadas;
            transaccionesOrdenadas = this.ordenarTransaccionesFecha(transacciones);
            //la escribo la lista de transaacciones en el archivo en el archivo
            var path = Path.GetFullPath("../../DatosUsuario/Transacciones.txt");
            TextWriter tsw = new StreamWriter(path);
            int i = 0;
            foreach ( Transaccion t in transaccionesOrdenadas)
            {
                String append = i.ToString()+","+t.tipo+","+t.donde+","+t.cuando.ToString()+","+t.monto.ToString();
                //escribiendo en el archivo.
                tsw.WriteLine(append);
                i++;
            }
            //cerrar el archivo.
            tsw.Close();
        }

        public IEnumerable<Transaccion> ordenarTransaccionesFecha(List<Transaccion> transacciones)
        {
            IEnumerable<Transaccion> ordenado = transacciones.OrderByDescending(x => x.cuando);
            return ordenado;
        }

        public List<Transaccion> obtenerUltimasTransacciones()
        {
            //leer 5 lineas del archivo de transacciones
            //Leer el archivo donde estan las transacciones
            var path = Path.GetFullPath("../../DatosUsuario/Transacciones.txt");
            string[] lineas = System.IO.File.ReadAllLines(path);

            //guardarlas en una variable
            List<Transaccion> lista = new List<Transaccion>();

            if (lineas == null)
            {
                return null;
            }

            for (int i = 0; i < 5; i++)
            {
                Transaccion tr = new Transaccion();
                String[] separado = lineas[i].Split(',', '\n');
                tr.id = Int16.Parse(separado[0]);
                tr.tipo = separado[1];
                tr.donde = separado[2];
                tr.cuando = DateTime.Parse(separado[3]);
                tr.monto = Int32.Parse(separado[4]);
                lista.Add(tr);
            }
            //retornar las transacciones
            return lista;
        }


    }
}
