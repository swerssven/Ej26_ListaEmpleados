using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Ej26_ListaEmpleados
{
    abstract class Empleados
    {
        private String nombre;
        private String apellidos;
        private double sueldo;
        private String dni;

        protected Empleados(string nombre, string apellidos, double sueldo, string dni)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.sueldo = sueldo;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public string Dni { get => dni; set => dni = value; }

        public abstract String informacion();
    }
}
