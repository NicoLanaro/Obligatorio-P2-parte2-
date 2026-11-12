using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Fisica : Evidencia
    {
        public bool TieneHuellasDigitalesDelSospechoso {  get; set; }


        public Fisica(DateTime fechaRecoleccion, string descripcion, bool tieneHuellasDigitalesDelSospechoso)
        {
            FechaRecoleccion = fechaRecoleccion;
            Descripcion = descripcion;
            TieneHuellasDigitalesDelSospechoso = tieneHuellasDigitalesDelSospechoso;

            Validar();

        }


        public override int CalcularPeso()
        {
            return -1;
        }

       
    }
}
