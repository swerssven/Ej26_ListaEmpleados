using System;
using System.Collections.Generic;
using System.Text;

namespace Ej26_ListaEmpleados
{
    class Becarios : Empleados, Estudiantes
    {
        private String carrera;
        private String curso;
        private String departamento;
        private String university;
        private double nota1;
        private double nota2;
        private double nota3;

        public Becarios(string nombre, string apellidos, double sueldo, string dni, string carrera, string curso, string departamento) : base(nombre, apellidos, sueldo, dni)
        {
            this.carrera = carrera;
            this.curso = curso;
            this.departamento = departamento;
            this.University = university;
        }

        public string Carrera { get => carrera; set => carrera = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string University { get => university; set => university = value; }

        public override string informacion()
        {
            String info = "Tipo Empleado: Becario" +
                          "\nNombre: " + Nombre + 
                          "\nApellidos: " + Apellidos +
                          "\nSueldo: " + Sueldo + "€" +
                          "\nDNI: " + Dni +
                          "\nCarrera: " + carrera + 
                          "\nDepartamento: " + departamento;
            return info;
        }

        public double[] examenes()
        {
            double[] notas = new double[3];
            notas[0] = nota1;
            notas[1] = nota2;
            notas[2] = nota3;
            return notas;
        }

        public double notaMedia()
        {
            double mediaNotas = (examenes()[0] + examenes()[1] + examenes()[1]) / 3;
            mediaNotas = Math.Round(mediaNotas * 10) / 10;
            return mediaNotas;
        }

        public string universidad()
        {
            return University;
        }
    }
}
