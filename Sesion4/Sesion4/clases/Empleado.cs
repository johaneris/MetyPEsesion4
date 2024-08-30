using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4.clases
{

    /*calcular el salario neto del empleado*/

    //clase la compone 3 cosas, el nombre mayuscutla y singular, los atributos(caracteristicas) mayuscula y metodos get y set, metodos, importante el contructor pq sino no se crea el objeto
    //clase object da origen a todos los objetos, la primera clase q se crea, la pirmera, viene en visual, la calse amdre puede crear nuevas instancias de sus hijos 
    internal class Empleado
    {
        //metodo contrusctor

        public Empleado() { }

        //atributos con mayuscula

        public int ID {  get; set; }
        public string FirtsName {  get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }

        public Empleado(int iD, string firtsName, string lastName, string email, string phone, double salary)
        {
            this.ID = iD;
            this.FirtsName = firtsName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.Salary = salary;
        }


        //solicita los parametros que voy a utilizar , crea dos pq aveces se ecesita uno vaci y otro con parametros 
        //crear otro constructor, es el que crea el objeto || encargado de crear un objeto
        //this = yo tengo un atributo











    }
}
