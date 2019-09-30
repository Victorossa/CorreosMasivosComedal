using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            EmployeeData empData = new EmployeeData();
            emp = empData.EmployeeDataOps();
            string JSONresult = JsonConvert.SerializeObject(emp);
            string path = @"C:\Users\programador1\source\repos\CorreosMasivos\JSON Creados\employee.json";
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
