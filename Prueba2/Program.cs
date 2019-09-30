using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace Prueba2
{
    class Program
    {
        public class Empleado
        {
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Genero { get; set; }
            public int Salario { get; set; }
            public List<DatosUbicacion> datosUbicacions { get; set; }

        }

        public class DatosUbicacion
        {
            public string Direccion { get; set; }
            public string Telefono { get; set; }   

        }

        

        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado { Nombres = "Juan", Apellidos = "Ramirez", Genero = "Masculino", Salario = 1200000, datosUbicacions = new List<DatosUbicacion>() { new DatosUbicacion() { Direccion = "Calle 99 # 78 - 12", Telefono = "2681212" }, new DatosUbicacion() { Direccion = "Calle 88 # 15 - 29", Telefono = "3415269" } } };
            Empleado empleado2 = new Empleado { Nombres = "Luisa", Apellidos = "Pimienta", Genero = "Femenino", Salario = 100000, datosUbicacions = new List<DatosUbicacion>() { new DatosUbicacion() { Direccion = "Calle 99 # 78 - 12", Telefono = "2681212" } } };
            Empleado empleado3 = new Empleado { Nombres = "Raul", Apellidos = "Acosta", Genero = "Masculino", Salario = 200000 };
            Empleado empleado4 = new Empleado { Nombres = "Pëdro", Apellidos = "Ruiz", Genero = "Masculino", Salario = 2000000 };

            List<Empleado> ListaEmp = new List<Empleado>();
            ListaEmp.Add(empleado1);
            ListaEmp.Add(empleado2);
            ListaEmp.Add(empleado3);
            ListaEmp.Add(empleado4);
            
            JavaScriptSerializer Javesvfr = new JavaScriptSerializer();
            string jsonString = Javesvfr.Serialize(ListaEmp);
            Console.WriteLine(jsonString);
            Console.ReadLine();
        }
    }
}
