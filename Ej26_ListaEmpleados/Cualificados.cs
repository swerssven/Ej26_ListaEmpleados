using System;
using System.Collections.Generic;
using System.Text;

namespace Ej26_ListaEmpleados
{
    class Cualificados : Empleados
    {
        private String titulacion;
        private double plus;
        private String departamento;

        public Cualificados(string nombre, string apellidos, double sueldo, string dni, string titulacion, double plus, string departamento) : base(nombre, apellidos, sueldo, dni)
        {
            this.titulacion = titulacion;
            this.Plus = plus;
            this.departamento = departamento;
        }

        public string Titulacion { get => titulacion; set => titulacion = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public double Plus { get => plus; set => plus = value; }

        public override string informacion()
        {
            String info = "Tipo Empleado: Cualificado" +
                          "\nNombre: " + Nombre +
                          "\nApellidos: " + Apellidos +
                          "\nSueldo: " + Sueldo + "€" +
                          "\nDNI: " + Dni +
                          "\nTitulación: " + titulacion + 
                          "\nPlus: " + plus +
                          "\nDepartamento: " + departamento;
            return info;
        }
    }
}
