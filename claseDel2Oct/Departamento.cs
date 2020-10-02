using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace claseDel2Oct
{
    class Departamento
    {
        private ArrayList employees = new ArrayList();
        
        public void agregarEmpleado(Persona emp)
        {
            employees.Add(emp);
        }

        public void removerEmpleado(Persona emp)
        {
            employees.Remove(emp);
        }

        //Encapsulamiento
        public ArrayList Employees
        {
            get
            {
                return employees;
            }

            set
            {
                employees = value;
            }
        }
    }
}
