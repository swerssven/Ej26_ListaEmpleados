using System;
using System.Collections.Generic;
using System.Text;

namespace Ej26_ListaEmpleados
{
    class JefeDepart : Cualificados
    {
        String totalTrabaCargo;
        String proyectos;
        double plus;

        public JefeDepart(string nombre, string apellidos, double sueldo, string dni, string titulacion, double plus, string departamento, string totalTrabaCargo, string proyectos) : base(nombre, apellidos, sueldo, dni, titulacion, plus, departamento)
        {
            this.totalTrabaCargo = totalTrabaCargo;
            this.proyectos = proyectos;
            this.plus = plus;
        }

        public string TotalTrabaCargo { get => totalTrabaCargo; set => totalTrabaCargo = value; }
        public string Cargo { get => proyectos; set => proyectos = value; }
        public double Plus1 { get => plus; set => plus = value; }

        public override string informacion()
        {
            return base.informacion().Replace("Cualificado", "Jefe Departamento") + 
                "\nCargo :" + totalTrabaCargo + 
                "\nProyecto: " + proyectos +
                "\nPlus: " + plus;
        }
    }
}
