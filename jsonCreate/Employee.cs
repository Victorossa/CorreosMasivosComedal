using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonCreate
{
    public class Employee
    {
        public string FirstName = "Victor Andres";
        public string LastName = "Ossa Londoño";
        public int employeeID;
        public string Designation = "Full Stack JS y DevOps";
        public List<string> KnownLanguages = new List<string> { "C#", "Java", "Perl" };
        public Car car { get; set; }
    }

    public class EmployeeData
    {
        public Employee EmployeeDataOps()
        {
            int locationCode = 78;
            int employeeNumber = 298676;

            int empID = int.Parse(locationCode.ToString() + employeeNumber.ToString());

            Employee EmpObj = new Employee();
            Car carObj = new Car();

            EmpObj.employeeID = empID;
            EmpObj.car = carObj;
            

            return EmpObj;
        }
    }


    public class Car 
    {
        public string makeModel = "Suzuky GS 125";
        public int makeYear = 2008;
        public string color = "Black";
        public string type = "Motorcicle";

    }

}
