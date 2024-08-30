using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4.clases
{
    internal class RRHH
    {
        public RRHH() { }

        //calcular el salario neto

        //metodos en mayuscula :3
        public double CalcularSalario(Empleado empleado, double deducciones)
        {
            return empleado.Salary - deducciones;

        }

        //aumentar el salario en un 5% si su salario es menor a 10,000

        public void AumentarSalario(Empleado empleado, double porcentaje, double techo)
        {
            //operador ternario, el : es como el else
            empleado.Salary = (empleado.Salary <= techo) ? empleado.Salary = (empleado.Salary * (1 + porcentaje)) : empleado.Salary;
        }
    }
}
