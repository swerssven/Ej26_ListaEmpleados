using System;
using System.Collections.Generic;
using System.Text;

namespace Ej26_ListaEmpleados
{
    class Obreros : Empleados
    {
        private String destinoTrabajo;
        private int horasExtra;
        private double precioHE;

        public Obreros(string nombre, string apellidos, double sueldo, string dni, int horasExtra, double precioHE, string destinoTrabajo) : base(nombre, apellidos, sueldo, dni)
        {
            this.destinoTrabajo = destinoTrabajo;
            this.horasExtra = horasExtra;
            this.precioHE = precioHE;
        }

        public string DestinoTrabajo { get => destinoTrabajo; set => destinoTrabajo = value; }
        public int HorasExtra { get => horasExtra; set => horasExtra = value; }
        public double PrecioHE { get => precioHE; set => precioHE = value; }

        public override string informacion()
        {
            String info = "Tipo Empleado: Obrero" +
                          "\nNombre: " + Nombre +
                          "\nApellidos: " + Apellidos +
                          "\nSueldo: " + Sueldo + "€" +
                          "\nDNI: " + Dni +
                          "\nDestino: " + destinoTrabajo +
                          "\nHoras Extras: " + horasExtra +
                          "\nPrecio HE: " + precioHE;
            return info;
        }
    }
}
