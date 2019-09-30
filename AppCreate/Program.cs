using AppCreate.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace AppCreate
{
    class Program
    {
        [DataContract]
        class persona
        {
            [DataMember]
            public string Nombre { get; set; }
            [DataMember]
            public int Edad { get; set; }

            public persona(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }
        }



        static void Main(string[] args)
        {

            persona persona1 = new persona("Manuel",44);
            persona persona2 = new persona("Carlota", 54);
            persona persona3 = new persona("Miguel", 25);
            persona[] gente = new persona[] { persona1,persona2,persona3 };

            DataContractJsonSerializer jsonF = new DataContractJsonSerializer(typeof(persona[]));

            using (FileStream fs = new FileStream("gente.json", FileMode.OpenOrCreate))
            {
                jsonF.WriteObject(fs, gente);
            }
            using (FileStream fs = new FileStream("gente.json", FileMode.OpenOrCreate))
            {
                persona[] personas = (persona[])jsonF.ReadObject(fs);
                foreach (persona item in personas)
                {
                    Console.WriteLine("Nombre:{0}  Edad {1}",item.Nombre,item.Edad);
                }
                    
            }

            Console.ReadLine();
        }

        


    }


}
