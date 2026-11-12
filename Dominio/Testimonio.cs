using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Testimonio : Evidencia
    {
        public string NombreTestigo { get; set; }
        public IndiceCredibilidad IndiceCredibilidad { get; set; }




        public Testimonio()
        {
        
        }


        public Testimonio(DateTime fechaRecoleccion, string descripcion, string nombreTestigo, IndiceCredibilidad indiceCredibilidad)
        {
            FechaRecoleccion = fechaRecoleccion;
            Descripcion = descripcion;
            NombreTestigo = nombreTestigo;      
            IndiceCredibilidad = indiceCredibilidad;

            Validar();
        }


        public override int CalcularPeso()
        {
            return -1;
        }

        public override void Validar()
        {
            base.Validar();
            ValidarNombreTestigo();

        }

        private void ValidarNombreTestigo()
        {
            if(string.IsNullOrEmpty(NombreTestigo))
            {
                throw new Exception("El nombre del testigo es obligatorio");
            }
        }
        



    }

   
}
