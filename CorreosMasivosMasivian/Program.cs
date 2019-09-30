using CorreosMasivosMasivian.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreosMasivosMasivian
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjetoCorreo objCorreo = new ObjetoCorreo();
            string JSONresult = JsonConvert.SerializeObject(objCorreo);
            string path = @"C:\Users\programador1\source\repos\CorreosMasivos\JSON Creados\correos.json";
            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }

            Console.WriteLine(JSONresult.ToString());
            Console.ReadLine();

        }
    }
}
